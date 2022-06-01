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
    public partial class frmDetallesVentas : Form
    {
        private Venta miVenta = new Venta();

        public frmDetallesVentas()
        {
            InitializeComponent();
        }

        private async void frmDetallesCompras_Load(object sender, EventArgs e)
        {
            await miVenta.CargarLista();
            miVenta.DeserializarListaVenta();
            foreach (Venta venta in miVenta.misVentas)
            {
                cbxID.Items.Add(venta.IDVenta);
            }
        }

        private void ActualizarDataGrid()
        {
            dtgProductosVendidos.Rows.Clear();
            for (int x = 0; x < miVenta.misVentas.Count; x++)
            {
                foreach (Producto miProducto in miVenta.misVentas[x].misProductosVenta)
                {
                    if (miProducto.IDVenta == cbxID.Text)
                    {
                        dtgProductosVendidos.Rows.Add(miProducto.IDProducto, miProducto.NombreProducto, miProducto.PrecioCompra, miProducto.PrecioVenta, miProducto.StockProducto, miProducto.PrecioVenta * miProducto.StockProducto, (miProducto.PrecioVenta * miProducto.StockProducto) - (miProducto.PrecioCompra * miProducto.StockProducto));
                    }
                }
            }
        }

        private void cbxID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarDataGrid();

            lblDatos.Text = $"ID de la venta: {miVenta.misVentas[cbxID.SelectedIndex].IDVenta}\n" +
                            $"Fecha: {miVenta.misVentas[cbxID.SelectedIndex].FechaVenta}\n" +
                            $"Monto total: {miVenta.misVentas[cbxID.SelectedIndex].TotalVenta}";
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
           

            GuardarTicket(miVenta.misVentas[miVenta.misVentas.FindIndex(x => x.IDVenta.ToString() == cbxID.Text)]);
        }

        private void GuardarTicket(Venta venta)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", $"venta_{venta.IDVenta}");

            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
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
    }
}