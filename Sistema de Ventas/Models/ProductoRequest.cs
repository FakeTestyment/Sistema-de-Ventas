using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Ventas.Models
{
    public class ProductoRequest
    {
        public int IDProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? PrecioVenta { get; set; }
        
        public string ImagenProducto { get; set; }

        public string NombreImagen { get; set; }
    }
}
