using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Sistema_de_Ventas
{
    public partial class frmUsuarios : Form
    {
        private Usuario miUsuario = new Usuario();
        private bool isConnectedToInternet;

        public frmUsuarios(Usuario UsuarioActual)
        {
            InitializeComponent();
            miUsuario = UsuarioActual;
        }

        private void ActualizarDataGrid()
        {
            dtgUsuarios.Rows.Clear();
            foreach (Usuario miUsuario in miUsuario.misUsuarios)
            {
                dtgUsuarios.Rows.Add(miUsuario.Id, miUsuario.Nombre, miUsuario.Correo, miUsuario.Rol == 1 ? "Administrador" : "Empleado", miUsuario.Contraseña);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indexBusqueda = -1;
            if (txtBusqueda.Text == "")
            {
                MessageBox.Show("Campo de búsqueda vacío");
                return;
            }
            switch (cbxBuscar.Text)
            {
                case "Nombre":
                    indexBusqueda = miUsuario.misUsuarios.FindIndex(x => x.Nombre.Contains(txtBusqueda.Text));
                    break;

                case "ID":
                    indexBusqueda = miUsuario.misUsuarios.FindIndex(x => x.Id.ToString().Contains(txtBusqueda.Text));
                    break;

                case "Correo":
                    indexBusqueda = miUsuario.misUsuarios.FindIndex(x => x.Correo.Contains(txtBusqueda.Text));
                    break;

                default:
                    MessageBox.Show("Seleccione una opción de búsqueda");
                    break;
            }
            if (indexBusqueda == -1)
            {
                MessageBox.Show($"No se encontró un usuario con este {cbxBuscar.Text}");
                return;
            }
            dtgUsuarios.Rows[indexBusqueda].Selected = true;
        }

        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in datosContainer.Controls)
            {
                if (control.Text.Trim() == "" || control.Text == "0.00")
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtCorreo.Text);

            if (!match.Success)

            {
                MessageBox.Show("Ingrese una direccion de correo valida");
                return;
            }

            if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show("Por favor verifique las contraseñas");
                return;
            }

            if (miUsuario.misUsuarios.FindIndex(x => x.Nombre == txtNombre.Text) != -1)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre");
                return;
            }

            if (miUsuario.misUsuarios.FindIndex(x => x.Correo == txtCorreo.Text) != -1)
            {
                MessageBox.Show("Ya existe un usuario con ese correo");
                return;
            }

            if (miUsuario.misUsuarios.FindIndex(x => x.Id.ToString() == txtID.Text) != -1)
            {
                var messageBox = MessageBox.Show($"Ya existe un usuario con el ID: {txtID.Text} ¿Desea sobreescribirlo?", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                if (messageBox == DialogResult.No) return;
                else await miUsuario.EliminarUsuario(int.Parse(txtID.Value.ToString()));
            }

            var usuario = new Usuario
            {
                Id = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Contraseña = txtContraseña.Text,
                Rol = cbxRol.SelectedIndex
            };

            await miUsuario.AñadirUsuario(usuario);
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void dtgUsuarios_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dtgUsuarios.CurrentCell.RowIndex >= 0 && dtgUsuarios.CurrentCell.RowIndex < miUsuario.misUsuarios.Count)
            {
                txtID.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Id.ToString();
                txtNombre.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Nombre;
                txtCorreo.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Correo;
                cbxRol.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Rol == 1 ? "Administrador" : "Empleado";
                txtContraseña.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Contraseña;
                txtConfirmarContraseña.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Contraseña;
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            isConnectedToInternet = Internet.IsConnectedToInternet();
            miUsuario.CargarLista();
            ActualizarDataGrid();
        }

        private void LimpiarDatos()
        {
            foreach (Control control in datosContainer.Controls)
            {
                if (control is TextBox) control.Text = "";
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Nombre == "admin")
            {
                MessageBox.Show("Accion no permitida");
                return;
            }
            else if (miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Nombre == miUsuario.Nombre)
            {
                MessageBox.Show("No puedes borrar tu propio usuario");
                return;
            }
            else if (miUsuario.Rol == 0)
            {
                MessageBox.Show("No tienes los permisos para ejecutar esa accion");
                return;
            }
            await miUsuario.EliminarUsuario(miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Id);
            await miUsuario.CargarLista();
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            int indexBusqueda = -1;
            if (txtBusqueda.Text == "")
            {
                MessageBox.Show("Campo de búsqueda vacío");
                return;
            }
            switch (cbxBuscar.Text)
            {
                case "Nombre":
                    indexBusqueda = miUsuario.misUsuarios.FindIndex(x => x.Nombre.Contains(txtBusqueda.Text));
                    break;

                case "ID":
                    indexBusqueda = miUsuario.misUsuarios.FindIndex(x => x.Id.ToString().Contains(txtBusqueda.Text));
                    break;

                case "Correo":
                    indexBusqueda = miUsuario.misUsuarios.FindIndex(x => x.Correo.Contains(txtBusqueda.Text));
                    break;

                default:
                    MessageBox.Show("Seleccione una opción de búsqueda");
                    break;
            }
            if (indexBusqueda == -1)
            {
                MessageBox.Show($"No se encontró un usuario con este {cbxBuscar.Text}");
                return;
            }
            dtgUsuarios.Rows[indexBusqueda].Selected = true;
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await miUsuario.CargarLista();
            ActualizarDataGrid();
        }
    }
}