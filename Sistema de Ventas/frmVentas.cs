using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class frmVentas : Form
    {
        private Inventario miProducto = new Inventario();
        private Cliente miCliente = new Cliente();
        private Venta miVenta = new Venta();

        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            miProducto.DeserializarLista();
            miCliente.DeserializarLista();
            miVenta.DeserializarListaVenta();
            foreach (Inventario producto in miProducto.misProductos)
            {
                cbxSeleccionarProducto.Items.Add("ID " + producto.IDProducto + "  " + producto.NombreProducto);
            }
            foreach (Cliente Cliente in miCliente.misClientes)
            {
                cbxSeleccionarCliente.Items.Add(Cliente.Id + " " + Cliente.Nombre);
            }
        }

        private void cbxSeleccionarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrecio.Text = miProducto.misProductos[cbxSeleccionarProducto.SelectedIndex].PrecioVenta.ToString();
            lblStockDisponible.Text = miProducto.misProductos[cbxSeleccionarProducto.SelectedIndex].StockProducto.ToString();
            lblNombre.Text = miProducto.misProductos[cbxSeleccionarProducto.SelectedIndex].NombreProducto;
        }

        private void LimpiarDatos()
        {
            foreach (Control control in datosContainer.Controls)
            {
                NumericUpDown nud = control as NumericUpDown;
                ComboBox cbx = control as ComboBox;
                if (control is TextBox) control.Text = "";
                if (control is NumericUpDown) nud.Value = 0;
                if (control is ComboBox) cbx.Text = "";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbxSeleccionarProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            if (nudCantidad.Value > miProducto.misProductos[cbxSeleccionarProducto.SelectedIndex].StockProducto || nudCantidad.Value == 0)
            {
                MessageBox.Show($"Solo hay {miProducto.misProductos[cbxSeleccionarProducto.SelectedIndex].StockProducto} productos disponibles en stock");
                return;
            }
            var miProductoModelo = miProducto.misProductos[cbxSeleccionarProducto.SelectedIndex];
            var producto = new Inventario
            {
                IDProducto = miProductoModelo.IDProducto,
                NombreProducto = miProductoModelo.NombreProducto,
                StockProducto = (int)nudCantidad.Value,
                PrecioCompra = miProductoModelo.PrecioCompra,
                PrecioVenta = miProductoModelo.PrecioVenta,
                IDCompra = miProductoModelo.IDCompra
            };

            if (miVenta.misProductosVenta.Contains(producto))
            {
                MessageBox.Show($"Este producto ya ha sido agregado al carrito");
                return;
            }
            miVenta.misProductosVenta.Add(producto);

            lblTotalVenta.Text = $"Total: ${miVenta.CalcularTotal()}";

            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void ActualizarDataGrid()
        {
            dtgProductosVenta.Rows.Clear();
            foreach (Inventario productoVenta in miVenta.misProductosVenta)
            {
                dtgProductosVenta.Rows.Add(productoVenta.IDProducto, productoVenta.NombreProducto, "$" + productoVenta.PrecioCompra, productoVenta.StockProducto, "$" + productoVenta.PrecioVenta * productoVenta.StockProducto);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            miVenta.misProductosVenta.RemoveAt(dtgProductosVenta.CurrentCell.RowIndex);
            miVenta.CalcularTotal();
            lblTotalVenta.Text = $"Total: ${miVenta.CalcularTotal()}";
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void dtgProductosVenta_SelectionChanged(object sender, EventArgs e)
        {
            int i = dtgProductosVenta.CurrentCell.RowIndex;
            if (i >= 0 && i < miVenta.misProductosVenta.Count)
            {
                cbxSeleccionarProducto.Text = "Producto " + miVenta.misProductosVenta[i].IDProducto.ToString() + "  " + miVenta.misProductosVenta[i].NombreProducto;
                lblPrecio.Text = miVenta.misProductosVenta[i].PrecioVenta.ToString();
                lblStockDisponible.Text = miVenta.misProductosVenta[i].StockProducto.ToString();
            }
        }

        private void GuardarTicket(Venta venta)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", $"venta_{venta.IDVenta}");

            string ticketHtml = Properties.Resources.ticket.ToString();
            ticketHtml = ticketHtml.Replace("@idcliente", venta.IDCliente);
            ticketHtml = ticketHtml.Replace("@nombrecliente", venta.NombreCliente);
            ticketHtml = ticketHtml.Replace("@idventa", venta.IDVenta);
            ticketHtml = ticketHtml.Replace("@fecha", venta.FechaVenta);

            string filas = string.Empty;
            decimal total = miVenta.TotalVenta;

            foreach (Inventario producto in venta.misProductosVenta)
            {
                filas += "<tr>";
                filas += "<td>" + producto.NombreProducto + "</td>";
                filas += "<td>" + producto.StockProducto + "</td>";
                filas += "<td>" + "$" + producto.PrecioVenta + "</td>";
                filas += "<td>" + "$" + producto.PrecioVenta * producto.StockProducto + "</td>";
                filas += "</tr>";
            }
            ticketHtml = ticketHtml.Replace("@total", "$" + total.ToString());
            ticketHtml = ticketHtml.Replace("@pagocon", "$" + venta.MontoPago.ToString());
            ticketHtml = ticketHtml.Replace("@cambio", "$" + venta.MontoCambio.ToString());

            ticketHtml = ticketHtml.Replace("@FILAS", filas);

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    using (StringReader sr = new StringReader(ticketHtml))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
                System.Diagnostics.Process.Start(savefile.FileName);
            }
        }

        private async void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (nudMontoPago.Value < miVenta.TotalVenta)
            {
                MessageBox.Show("El monto pagado no puede ser menor al total");
                return;
            }
            if (miVenta.misProductosVenta.Count == 0)
            {
                MessageBox.Show("Agregue por lo menos un producto");
                return;
            }
            if (txtIdVenta.Value == 0)
            {
                MessageBox.Show("Ingrese un ID de compra");
                return;
            }
            foreach (Producto product in miVenta.misProductosVenta)
            {
                product.IDVenta = txtIdVenta.Text.ToString();
            }

            string[] arr = cbxSeleccionarCliente.Text.Split(' ');

            var venta = new Venta
            {
                FechaVenta = DateTime.Now.ToString(),
                IDVenta = txtIdVenta.Text,
                TotalVenta = miVenta.TotalVenta,
                MontoPago = nudMontoPago.Value,
                IDCliente = arr[0].ToString(),
                NombreCliente = miCliente.misClientes[cbxSeleccionarCliente.SelectedIndex].Nombre,
                MontoCambio = nudMontoPago.Value - miVenta.TotalVenta,
                misProductosVenta = miVenta.misProductosVenta,
            };

            int NuevoStock = 0;
            int idActualizar = 0;

            var repetido = miVenta.misVentas.FindIndex(x => x.IDVenta == venta.IDVenta);
            if (repetido != -1)
            {
                MessageBox.Show("Ya hay una venta con ese ID, ingrese otro");
                return;
            }

            foreach (Producto producto in miVenta.misProductosVenta)
            {
                for (int x = 0; x < miProducto.misProductos.Count; x++)
                {
                    if (producto.IDProducto == miProducto.misProductos[x].IDProducto)
                    {
                        idActualizar = miProducto.misProductos[x].IDProducto;
                        NuevoStock = miProducto.misProductos[x].StockProducto - producto.StockProducto;
                    }
                }
            }

            GuardarTicket(venta);

            await miProducto.ActualizarStock(idActualizar, NuevoStock);
            await miVenta.FinalizarVenta(venta);
            miVenta.misProductosVenta.Clear();
            MessageBox.Show("Los productos se han vendido correctamente");
            LimpiarDatos();
            ActualizarDataGrid();
        }

        private void nudMontoPago_ValueChanged(object sender, EventArgs e)
        {
            lblCambio.Text = $"Cambio: ${nudMontoPago.Value - miVenta.CalcularTotal()}";
        }

        private void panelVenta_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}