using Newtonsoft.Json;
using Sistema_de_Ventas.Models;
using Sistema_de_Ventas.Tools;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class Login : Form
    {
        private AuthRequest user = new AuthRequest();
        public Usuario miUsuario = new Usuario();

        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async static Task<Usuario> login(AuthRequest user)
        {
            string url = "http://apiventas.somee.com/api/userauth/login";
            var stringPayload = JsonConvert.SerializeObject(user);
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            var httpClient = new HttpClient();
            var httpResponse = await httpClient.PostAsync(url, httpContent);
            var responseContent = await httpResponse.Content.ReadAsStringAsync();
            Usuario obj = JsonConvert.DeserializeObject<Usuario>(responseContent);
            return obj;
        }

        private static Usuario loginOffline(AuthRequest user, Usuario miUsuario)
        {
            bool result = false;
            miUsuario.misUsuarios = Serializador.Deserializar<List<Usuario>>("misUsuariosOffline.json");
            for (int x = 0; x < miUsuario.misUsuarios.Count; x++)
            {
                if (user.Email == miUsuario.misUsuarios[x].Correo && Encrypt.GetSHA256(user.Password) == miUsuario.misUsuarios[x].Contraseña)
                {
                    Usuario objr = miUsuario.misUsuarios[x];
                    result = true;
                    return objr;
                }
            }
            return null;
        }

        private async void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            user.Email = txtNombre.Text;
            user.Password = txtContraseña.Text;

            if (Internet.IsConnectedToInternet())
            {
                var obj = await login(user);
                if (obj != null)
                {
                    try
                    {
                        if (obj.mensaje == "Sesion iniciada correctamente" && obj.mensaje != "ninguna sesion activa")
                        {
                            Inicio form = new Inicio(obj);
                            form.Show();
                            this.Hide();
                            form.FormClosing += frmClosing;
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    Usuario objr = await logout(user);
                    if (objr != null)
                    {
                        try
                        {
                            if (objr.mensaje == "Sesion iniciada correctamente" && objr.mensaje != "ninguna sesion activa")
                            {
                                Inicio form = new Inicio(objr);
                                form.Show();
                                this.Hide();
                                form.FormClosing += frmClosing;
                            }
                            else
                            {
                                MessageBox.Show("Datos incorrectos");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                Usuario objr = loginOffline(user, miUsuario);
                if (objr != null)
                {
                    Inicio form = new Inicio(objr);
                    form.Show();
                    this.Hide();
                    form.FormClosing += frmClosing;
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
        }

        private async static Task<Usuario> logout(AuthRequest user)
        {
            string urlr = "http://apiventas.somee.com/api/userauth/logout";
            var stringPayloadr = JsonConvert.SerializeObject(user);
            var httpContentr = new StringContent(stringPayloadr, Encoding.UTF8, "application/json");
            var httpClientr = new HttpClient();
            var httpResponser = await httpClientr.PostAsync(urlr, httpContentr);
            var responseContentr = await httpResponser.Content.ReadAsStringAsync();
            Usuario logoutResponse = JsonConvert.DeserializeObject<Usuario>(responseContentr);

            Usuario objr = await login(user);
            return objr;
        }

        private async void frmClosing(object sender, FormClosingEventArgs e)
        {
            if (Internet.IsConnectedToInternet())
            {
                string url = "http://apiventas.somee.com/api/userauth/logout";
                var stringPayload = JsonConvert.SerializeObject(user);
                var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
                var httpClient = new HttpClient();
                var httpResponse = await httpClient.PostAsync(url, httpContent);
                var responseContent = await httpResponse.Content.ReadAsStringAsync();
                Usuario obj = JsonConvert.DeserializeObject<Usuario>(responseContent);
                txtContraseña.Text = "";
                txtNombre.Text = "";
                this.Show();
            }
            else
            {
                txtContraseña.Text = "";
                txtNombre.Text = "";
                this.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}