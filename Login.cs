using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Security.Principal;
using Evaluacion1_Jenifer.Formularios;

namespace Evaluacion1_Jenifer
{
    public partial class Login : MaterialForm
    {
        public static String[] usuario = { "Jen" };
        public static String[] contrasennia = { "123" };
        public int Intentos = 3;

        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);


            //aca vamos a configurar el color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Cyan300, Primary.Cyan400,
                Primary.Cyan300, Accent.Cyan700,
                TextShade.WHITE);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void IngresarGestion_Click(object sender, EventArgs e)
        {
            string usuarioAutentica = Usuario.Text;
            string contrasenniaAutentica = txtContrasennia.Text;

            bool existeUser = Array.Exists(usuario, filtro => filtro == usuarioAutentica);
            bool existeContra = Array.Exists(contrasennia, filtro => filtro == contrasenniaAutentica);

            if (Intentos > 0)
            {
                if (string.IsNullOrEmpty(usuarioAutentica) || string.IsNullOrEmpty(contrasenniaAutentica))
                {
                    Usuario.Text = "";
                    txtContrasennia.Text = "";

                    MessageBox.Show("Usuario y/o contraseña tienen campos vacios",
                    "Error de acceso",

                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    Intentos = Intentos - 1;
                }
                else
                {
                    if (!existeUser || !existeContra)
                    {

                        Usuario.Text = "";
                        txtContrasennia.Text = "";

                        Intentos = Intentos - 1;

                        if (Intentos == 0)
                        {
                            MessageBox.Show("Te has quedado sin intentos, vuelve mas tarde!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show($"Usuario y/o contraseña no coinciden, quedan {Intentos} intentos");
                        }


                    }
                    else
                    {

                        Gestion EntraGestion = new Gestion();
                        EntraGestion.Show();


                    }
                }

            }
        }
    }
}
