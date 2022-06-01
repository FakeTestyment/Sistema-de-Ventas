using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace Sistema_de_Ventas
{
    public partial class frmCompras : Form
    {
        private Compra miCompra = new Compra();
        private Inventario miProducto = new Inventario();

        public frmCompras()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dtgProductosCompra.Rows.Clear();
            foreach (Inventario miProductoCompra in miCompra.misProductosCompra)
            {
                dtgProductosCompra.Rows.Add(miProductoCompra.IDProducto, miProductoCompra.NombreProducto, miProductoCompra.PrecioCompra, miProductoCompra.StockProducto, miProductoCompra.PrecioCompra * miProductoCompra.StockProducto);
            }
        }

        private void LimpiarDatos()
        {
            foreach (Control control in datosContainer.Controls)
            {
                NumericUpDown nud = control as NumericUpDown;
                ComboBox cbx = control as ComboBox;
                if (control is TextBox) control.Text = "";
                if (control is NumericUpDown) nud.Value = 0;
                if (control is ComboBox) cbx.Text = "Seleccionar producto:";
            }
        }

        private async void frmCompras_Load_1(object sender, EventArgs e)
        {
            await miProducto.CargarLista();
            miProducto.DeserializarLista();
            foreach (Inventario producto in miProducto.misProductos)
            {
                cbxSeleccionar.Items.Add("Producto " + producto.IDProducto + "  " + producto.NombreProducto);
            }
        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSeleccionar.Text = miProducto.misProductos[cbxSeleccionar.SelectedIndex].IDProducto.ToString();
            txtNombre.Text = miProducto.misProductos[cbxSeleccionar.SelectedIndex].NombreProducto;
            txtID.Value = miProducto.misProductos[cbxSeleccionar.SelectedIndex].IDProducto;
            nudPrecioCompra.Value = miProducto.misProductos[cbxSeleccionar.SelectedIndex].PrecioCompra;
            nudPrecioVenta.Value = miProducto.misProductos[cbxSeleccionar.SelectedIndex].PrecioVenta;
            txtStock.Text = miProducto.misProductos[cbxSeleccionar.SelectedIndex].StockProducto.ToString() + " ";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Control control in datosContainer.Controls)
            {
                if (control.Text.Trim() == "" || control.Text == "0.00" || control.Text == "0")
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }
            }

            var producto = new Inventario
            {
                IDProducto = (int)txtID.Value,
                NombreProducto = txtNombre.Text,
                StockProducto = (int)nudCantidad.Value,
                PrecioCompra = nudPrecioCompra.Value,
                PrecioVenta = nudPrecioVenta.Value,
                IDCompra = txtIDCompra.Text
            };

            miCompra.misProductosCompra.Add(producto);
            miCompra.CalcularTotal();
            lblPrecioAPagar.Text = $"Precio a pagar: {miCompra.TotalCompra}";
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            miCompra.misProductosCompra.RemoveAt(dtgProductosCompra.CurrentCell.RowIndex);
            miCompra.CalcularTotal();
            lblPrecioAPagar.Text = $"Precio a pagar: {miCompra.TotalCompra}";
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private async void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (txtIDCompra.Text == "")
            {
                MessageBox.Show("Ingrese un ID para la compra");
                return;
            }
            if (miCompra.misProductosCompra.Count == 0)
            {
                MessageBox.Show("Agregue por lo menos un producto");
                return;
            }

            var compra = new Compra
            {
                FechaCompra = DateTime.Now.ToString(),
                IDCompra = txtIDCompra.Text,
                TotalCompra = miCompra.TotalCompra,
                misProductosCompra = miCompra.misProductosCompra
            };

            int NuevoStock = 5;
            int idActualizar = 0;

            await miCompra.FinalizarCompra(compra);

            foreach (Inventario producto in miCompra.misProductosCompra)
            {
                for (int x = 0; x < miProducto.misProductos.Count; x++)
                {
                    if (producto.IDProducto == miProducto.misProductos[x].IDProducto)
                    {
                        idActualizar = miProducto.misProductos[x].IDProducto;
                        NuevoStock = miProducto.misProductos[x].StockProducto + producto.StockProducto;
                    }
                }
            }

            await miProducto.ActualizarStock(idActualizar, NuevoStock);
            miCompra.misProductosCompra.Clear();
            MessageBox.Show("Los productos se han agregado al inventario");
            LimpiarDatos();
            ActualizarDataGrid();
        }

        private void dtgProductosCompra_SelectionChanged_1(object sender, EventArgs e)
        {
            cbxSeleccionar.Text = miProducto.misProductos[cbxSeleccionar.SelectedIndex].IDProducto.ToString();
            txtNombre.Text = miProducto.misProductos[cbxSeleccionar.SelectedIndex].NombreProducto;
            nudPrecioCompra.Value = miProducto.misProductos[cbxSeleccionar.SelectedIndex].PrecioCompra;
            nudPrecioVenta.Value = miProducto.misProductos[cbxSeleccionar.SelectedIndex].PrecioVenta;
        }
    }
}