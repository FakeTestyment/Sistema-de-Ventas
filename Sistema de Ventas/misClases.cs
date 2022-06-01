using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public static class Internet
    {
        public static bool IsConnectedToInternet()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public static class Serializador
    {
        private static string carpeta = @"..\..\..\DatosJson\";

        public static void Serializar(string nombreArchivo, object miObjeto)
        {
            Directory.CreateDirectory(carpeta);

            using (Stream stream = File.Open(carpeta + nombreArchivo, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    try { sw.Write(JsonConvert.SerializeObject(miObjeto, Formatting.Indented)); }
                    catch (Exception) { throw; }
                }
            }
        }

        public static T Deserializar<T>(string nombreArchivo)
        {
            Directory.CreateDirectory(carpeta);
            string json;
            T objeto;
            using (Stream stream = File.Open(carpeta + nombreArchivo, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    json = sr.ReadToEnd();
                    if (stream.Length == 0) return default;
                    try { objeto = JsonConvert.DeserializeObject<T>(json); }
                    catch (Exception) { throw; }
                }
            }
            return objeto;
        }
    }

    public static class API
    {
        public static async Task Añadir(string posturl, object objeto)
        {
            var stringPayload = JsonConvert.SerializeObject(objeto);
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            var httpClient = new HttpClient();
            var content = await httpClient.PostAsync(posturl, httpContent);
            var responseContent = await content.Content.ReadAsStringAsync();
        }

        public static async Task Eliminar(string path, int Id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://apiventas.somee.com");
                var response = client.DeleteAsync(path + Id.ToString()).Result;

                if (response.IsSuccessStatusCode)
                {
                    if (path == "/api/product/") MessageBox.Show("Producto eliminado");
                    if (path == "/api/client/") MessageBox.Show("Cliente eliminado");
                    if (path == "/api/user/") MessageBox.Show("Usuario eliminado");
                    if (path == "/api/compra/") { MessageBox.Show("Compra eliminada"); }
                }
                else MessageBox.Show("Error");
            }
        }

        public static T CargarLista<T>(string url)
        {
            string respuesta = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                respuesta = reader.ReadToEnd();
            }

            T objeto;
            objeto = JsonConvert.DeserializeObject<T>(respuesta);
            return objeto;
        }
    }

    [Serializable]
    public class Inventario : Producto
    {
        [NonSerialized]
        public List<Inventario> misProductos = new List<Inventario>();

        public async Task AñadirProducto(Inventario miProducto)
        {
            await API.Añadir("http://apiventas.somee.com/api/product", miProducto);
            await CargarLista();
        }

        public async Task EliminarProducto(int Id)
        {
            await API.Eliminar("/api/product/", Id);
            File.Delete(@"..\..\..\Images\" + $"image_{ Id}.txt");
            await CargarLista();
        }

        public async Task ActualizarStock(int index, int NuevoStock)
        {
            using (var client = new HttpClient())
            {
                var stringPayload = JsonConvert.SerializeObject(NuevoStock.ToString());
                var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
                client.BaseAddress = new Uri("http://apiventas.somee.com");
                var response = client.PutAsync("/api/product/updatestock/" + index.ToString(), httpContent).Result;
            }
            await CargarLista();
        }

        public List<Inventario> DeserializarLista()
        {
            if (Serializador.Deserializar<List<Inventario>>("misProductos.json") == default) return misProductos;
            return misProductos = Serializador.Deserializar<List<Inventario>>("misProductos.json");
        }

        public async Task CargarLista()
        {
            misProductos = API.CargarLista<List<Inventario>>("http://apiventas.somee.com/api/product/");
            Serializador.Serializar("misProductos.json", misProductos);
        }

        public async Task<Stream> GetImageFromUrl(string url)
        {
            var httpClient = new HttpClient();
            var stream = await httpClient.GetStreamAsync(url);
            return stream;
        }
    }

    public abstract class Producto
    {
        public string IDVenta { get; set; }
        public string IDCompra { get; set; }
        public int IDProducto { get; set; }
        public string imagenProducto { get; set; }
        public string NombreImagen { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int StockProducto { get; set; }
    }

    [Serializable]
    public class Cliente : Persona
    {
        [NonSerialized]
        public List<Cliente> misClientes = new List<Cliente>();

        public async Task AñadirCliente(Cliente miCliente)
        {
            await API.Añadir("http://apiventas.somee.com/api/client/register", miCliente);
            await CargarLista();
        }

        public async Task EliminarCliente(int Id)
        {
            await API.Eliminar("/api/client/", Id);
            await CargarLista();
        }

        public void DeserializarLista()
        {
            if (Serializador.Deserializar<List<Cliente>>("misClientes.json") == default) return;
            misClientes = Serializador.Deserializar<List<Cliente>>("misClientes.json");
        }

        public override async Task CargarLista()
        {
            misClientes = API.CargarLista<List<Cliente>>("http://apiventas.somee.com/api/client");
            Serializador.Serializar("misClientes.json", misClientes);
        }
    }

    public abstract class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        abstract public Task CargarLista();
    }

    [Serializable]
    public class Usuario : Persona
    {
        [NonSerialized]
        public List<Usuario> misUsuarios = new List<Usuario>();

        public string Contraseña { get; set; }
        public int Rol { get; set; }
        public string mensaje { get; set; }

        public async Task AñadirUsuario(Usuario miUsuario)
        {
            await API.Añadir("http://apiventas.somee.com/api/userauth/register", miUsuario);
            await CargarLista();
        }

        public async Task EliminarUsuario(int index)
        {
            await API.Eliminar("/api/user/", index);
            await CargarLista();
        }

        public override async Task CargarLista()
        {
            misUsuarios = API.CargarLista<List<Usuario>>("http://apiventas.somee.com/api/user");
            Serializador.Serializar("misUsuarios.json", misUsuarios);
        }

        public List<Usuario> DeserializarLista()
        {
            if (Serializador.Deserializar<List<Usuario>>("misUsuarios.json") == default) return misUsuarios;
            return misUsuarios = Serializador.Deserializar<List<Usuario>>("misUsuarios.json");
        }
    }

    [Serializable]
    public class Compra
    {
        [NonSerialized]
        public List<Compra> misCompras = new List<Compra>();

        public List<Inventario> misProductosCompra = new List<Inventario>();

        public string FechaCompra { get; set; }
        public string IDCompra { get; set; }
        public decimal TotalCompra { get; set; }

        public decimal CalcularTotal()
        {
            TotalCompra = 0;
            foreach (Inventario miProducto in misProductosCompra)
            {
                TotalCompra += miProducto.PrecioCompra * miProducto.StockProducto;
            }
            return TotalCompra;
        }

        public async Task FinalizarCompra(Compra miCompra)
        {
            await API.Añadir("http://apiventas.somee.com/api/compra", miCompra);
            await CargarLista();
        }

        public async Task CargarLista()
        {
            misCompras = API.CargarLista<List<Compra>>("http://apiventas.somee.com/api/compra");
            Serializador.Serializar("misCompras.json", misCompras);
        }

        public List<Compra> DeserializarListaCompra()
        {
            if (Serializador.Deserializar<List<Compra>>("misCompras.json") == default) return misCompras;
            return misCompras = Serializador.Deserializar<List<Compra>>("misCompras.json");
        }
    }

    public class Venta
    {
        [NonSerialized]
        public List<Venta> misVentas = new List<Venta>();

        public List<Inventario> misProductosVenta = new List<Inventario>();
        public string FechaVenta { get; set; }
        public string IDVenta { get; set; }
        public string IDCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoPago { get; set; }
        public decimal TotalVenta { get; set; }
        public Cliente cliente { get; set; }

        public decimal CalcularTotal()
        {
            TotalVenta = 0;
            foreach (Inventario miProducto in misProductosVenta)
            {
                TotalVenta += miProducto.PrecioVenta * miProducto.StockProducto;
            }
            return TotalVenta;
        }

        public async Task FinalizarVenta(Venta miVenta)
        {
            await API.Añadir("http://apiventas.somee.com/api/venta", miVenta);
            await CargarLista();
        }

        public async Task CargarLista()
        {
            misVentas = API.CargarLista<List<Venta>>("http://apiventas.somee.com/api/venta");
            Serializador.Serializar("misVentas.json", misVentas);
        }

        public List<Venta> DeserializarListaVenta()
        {
            if (Serializador.Deserializar<List<Venta>>("misVentas.json") == default) return misVentas;
            return misVentas = Serializador.Deserializar<List<Venta>>("misVentas.json");
        }
    }
}