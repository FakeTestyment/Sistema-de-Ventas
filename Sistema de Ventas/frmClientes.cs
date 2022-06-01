using System;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class frmClientes : Form
    {
        private Cliente miCliente = new Cliente();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dtgClientes.Rows.Clear();
            foreach (Cliente miCliente in miCliente.misClientes)
            {
                dtgClientes.Rows.Add(miCliente.Id, miCliente.Nombre, miCliente.Correo, miCliente.Telefono);
            }
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
                    indexBusqueda = miCliente.misClientes.FindIndex(x => x.Nombre.Contains(txtBusqueda.Text));
                    break;

                case "ID":
                    indexBusqueda = miCliente.misClientes.FindIndex(x => x.Id.ToString().Contains(txtBusqueda.Text));
                    break;

                case "Correo":
                    indexBusqueda = miCliente.misClientes.FindIndex(x => x.Correo.Contains(txtBusqueda.Text));
                    break;

                case "Teléfono":
                    indexBusqueda = miCliente.misClientes.FindIndex(x => x.Telefono.Contains(txtBusqueda.Text));
                    break;

                default:
                    MessageBox.Show("Seleccione una opción de búsqueda");
                    break;
            }
            if (indexBusqueda == -1)
            {
                MessageBox.Show($"No se encontró un cliente con este {cbxBuscar.Text}");
                return;
            }
            dtgClientes.Rows[indexBusqueda].Selected = true;
        }

        private async void btnEliminar_Click_1(object sender, EventArgs e)
        {
            await miCliente.EliminarCliente(miCliente.misClientes[dtgClientes.CurrentCell.RowIndex].Id);
            await miCliente.CargarLista();
            ActualizarDataGrid();
            LimpiarDatos();
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

            if (miCliente.misClientes.FindIndex(x => x.Nombre == txtNombre.Text) != -1)
            {
                MessageBox.Show("Ya existe un cliente con ese nombre");
                return;
            }

            if (miCliente.misClientes.FindIndex(x => x.Correo == txtCorreo.Text) != -1)
            {
                MessageBox.Show("Ya existe un cliente con ese correo");
                return;
            }

            if (miCliente.misClientes.FindIndex(x => x.Id == int.Parse(txtID.Text)) != -1)
            {
                var messageBox = MessageBox.Show($"Ya existe un cliente con el ID: {txtID.Text} ¿Desea sobreescribirlo?", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                if (messageBox == DialogResult.No)
                {
                    return;
                }
                else
                {
                    await miCliente.EliminarCliente(int.Parse(txtID.Value.ToString()));
                }
            }

            var cliente = new Cliente
            {
                Id = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTeléfono.Text
            };

            await miCliente.AñadirCliente(cliente);
            await miCliente.CargarLista();
            miCliente.DeserializarLista();
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void dtgClientes_SelectionChanged_1(object sender, EventArgs e)
        {
            miCliente.DeserializarLista();
            if (dtgClientes.CurrentCell.RowIndex >= 0 && dtgClientes.CurrentCell.RowIndex < miCliente.misClientes.Count)
            {
                txtID.Text = miCliente.misClientes[dtgClientes.CurrentCell.RowIndex].Id.ToString();
                txtNombre.Text = miCliente.misClientes[dtgClientes.CurrentCell.RowIndex].Nombre;
                txtCorreo.Text = miCliente.misClientes[dtgClientes.CurrentCell.RowIndex].Correo;
                txtTeléfono.Text = miCliente.misClientes[dtgClientes.CurrentCell.RowIndex].Telefono;
            }
        }

        private async void frmClientes_Load(object sender, EventArgs e)
        {
            await miCliente.CargarLista();
            miCliente.DeserializarLista();
            ActualizarDataGrid();
        }

        private void LimpiarDatos()
        {
            foreach (Control control in datosContainer.Controls)
            {
                if (control is TextBox) control.Text = "";
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await miCliente.CargarLista();
            ActualizarDataGrid();
        }
    }
}