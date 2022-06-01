using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class frmDetallesCompras : Form
    {
        private Compra miCompra = new Compra();

        public frmDetallesCompras()
        {
            InitializeComponent();
        }

        private async void frmDetallesCompras_Load(object sender, EventArgs e)
        {
            await miCompra.CargarLista();
            miCompra.DeserializarListaCompra();
            foreach (Compra compra in miCompra.misCompras)
            {
                cbxID.Items.Add(compra.IDCompra);
            }
        }

        private void ActualizarDataGrid()
        {
            dtgProductosComprados.Rows.Clear();
            for (int x = 0; x < miCompra.misCompras.Count; x++)
            {
                foreach (Producto miProducto in miCompra.misCompras[x].misProductosCompra)
                {
                    if (miProducto.IDCompra == cbxID.Text)
                    {
                        dtgProductosComprados.Rows.Add(miProducto.IDProducto, miProducto.NombreProducto, miProducto.PrecioCompra, miProducto.StockProducto, miProducto.PrecioCompra * miProducto.StockProducto);
                    }
                }
            }
        }

        private void cbxID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarDataGrid();

            lblDatos.Text = $"ID de la compra: {miCompra.misCompras[cbxID.SelectedIndex].IDCompra}\n" +
                            $"Fecha: {miCompra.misCompras[cbxID.SelectedIndex].FechaCompra}\n" +
                            $"Monto total: { miCompra.misCompras[cbxID.SelectedIndex].TotalCompra}";
        }
    }
}