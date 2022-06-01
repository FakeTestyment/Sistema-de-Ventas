using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Sistema_de_Ventas
{
    public partial class Inicio : Form
    {
        private Usuario usuarioActual;
        private IconMenuItem MenuActivo = null;
        private Form formularioActivo = null;
        private Inventario miProducto = new Inventario();

        public Inicio(Usuario miUsuario)
        {
            usuarioActual = miUsuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"{usuarioActual.Nombre}";

            if (usuarioActual.Rol == 0)
            {
                menuCompras.Visible = false;
                menuUsuarios.Visible = false;
            }
            menuProductos.PerformClick();
        }

        private void AbrirForms(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.ForeColor = Color.FromArgb(167, 173, 209);
                MenuActivo.IconColor = Color.FromArgb(167, 173, 209);
            }
            menu.ForeColor = Color.FromArgb(79, 87, 170);
            menu.IconColor = Color.FromArgb(79, 87, 170);
            lblMenuSeleccionado.Text = menu.Text;
            MenuActivo = menu;

            if (formularioActivo != null) formularioActivo.Close();
            formularioActivo = formulario;
            formulario.TopLevel = false;

            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            container1.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmClientes());
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmProductos(miProducto));
        }

        private void menuUsuarios_Click_1(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmUsuarios(usuarioActual));
        }

        private void menuAñadirCompra_Click_1(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmCompras());
        }

        private void menuVerCompras_Click_1(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmDetallesCompras());
        }

        private void menuVentas_Click(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmVentas());
        }

        private void MenuVerVentas_Click(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmDetallesVentas());
        }
    }
}