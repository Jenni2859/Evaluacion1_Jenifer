using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion1_Jenifer.Formularios
{
    public partial class Gestion : MaterialForm
    {
        string[] Productos = { "Blusa", "Camisa", "Jeans Hombre", " Jeans Mujer", "Zapateria" };
        int[] unidadesCompra = { };
        double[] precioUnidad = { };
        double[] totalPago = { };
        string[] Clientes = { };

        public Gestion()
        {
            InitializeComponent();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            mcbProductos.Items.AddRange(Productos);
            CopiaUsuario.Text = $"Usuario conectado: {Login.usuario[0]}";
            // Mensajes.Text = CamposVacios(new object[] { tbCliente, tbUnidades, tbPrecioU, tbTotal }, new object[] { mcbProductos });
        }


        private void tbUnidades_TextChanged(object sender, EventArgs e)
        {

            //hay unidades
            if (tbUnidades.Text.Length >= 0)
            {
                //es unidades
                double numero = 0;
                bool EsNumero = double.TryParse(tbUnidades.Text, out numero);

                

                if (EsNumero)
                {
                    int unidadesCompradas = Convert.ToInt32(tbUnidades.Text);
                    //hay precio
                    if (string.IsNullOrEmpty(tbPrecioU.Text))
                    {
                    }
                    else
                    {
                        // es precio
                        double num = 0;
                        bool EsNum = double.TryParse(tbPrecioU.Text, out numero);


                        

                        if (EsNum)
                        {
                            int PrecioUnitario = Convert.ToInt32(tbPrecioU.Text);
                            tbTotal.Text = "" + PrecioUnitario * unidadesCompradas;

                        }
                        else
                        {
                            tbPrecioU.Focus();
                            tbPrecioU.Hint = "Debe de ser un numero";
                            tbPrecioU.SelectAll();
                            tbPrecioU.BackColor = Color.Red;
                            tbPrecioU.Text = "" + unidadesCompradas;
                        }

                    }

                }
                else
                {
                    tbUnidades.Focus();
                    tbUnidades.Hint = "Debe de ser un numero";
                    tbUnidades.SelectAll();
                    tbUnidades.BackColor = Color.Red;
                    tbTotal.Text = "";
                }




            }
        }
        private void tbPrecioU_TextChanged(object sender, EventArgs e)
        {
            //hay unidades
            if (tbPrecioU.Text.Length >= 0)
            {
                //es unidades
                double numero = 0;
                bool EsNumero = double.TryParse(tbPrecioU.Text, out numero);



                if (EsNumero)
                {
                    int unidadesCompradas = Convert.ToInt32(tbPrecioU.Text);
                    //hay precio
                    if (string.IsNullOrEmpty(tbUnidades.Text))
                    {
                    }
                    else
                    {
                        // es precio
                        double num = 0;
                        bool EsNum = double.TryParse(tbUnidades.Text, out numero);




                        if (EsNum)
                        {
                            int PrecioUnitario = Convert.ToInt32(tbUnidades.Text);
                            tbTotal.Text = "" + PrecioUnitario * unidadesCompradas;

                        }
                        else
                        {
                            tbUnidades.Focus();
                            tbUnidades.Hint = "Debe de ser un numero";
                            tbUnidades.SelectAll();
                            tbUnidades.BackColor = Color.Red;
                            tbUnidades.Text = "" + unidadesCompradas;
                        }

                    }

                }
                else
                {
                    tbPrecioU.Focus();
                    tbPrecioU.Hint = "Debe de ser un numero";
                    tbPrecioU.SelectAll();
                    tbPrecioU.BackColor = Color.Red;
                    tbTotal.Text = "";
                }




            }
        }


        private void Comprar_Click(object sender, EventArgs e)
        {
            string Product = mcbProductos.Text;
            int Units = Convert.ToInt16(tbUnidades.Text);
            double PrecioUnit = Convert.ToDouble(tbPrecioU.Text);
            double total = Convert.ToDouble(tbTotal.Text);
            string Customers = tbCliente.Text;

            if (CamposVacios(new object[] { tbCliente, tbUnidades, tbPrecioU, tbTotal }, new object[] { mcbProductos }))
            {
                MessageBox.Show("Existen campos vacios");
                // Mensajes.Text = CamposVacios(new object[] { tbCliente, tbUnidades, tbPrecioU, tbTotal });
            }
            else
            {
                //Array.Resize(ref Productos, Productos.Length + 1); no me guarda el valor del producto
                Array.Resize(ref unidadesCompra, unidadesCompra.Length + 1);
                Array.Resize(ref precioUnidad, precioUnidad.Length + 1);
                Array.Resize(ref totalPago, totalPago.Length + 1);
                Array.Resize(ref Clientes, Clientes.Length + 1);

                //Productos[Productos.Length - 1] = Product;
                unidadesCompra[unidadesCompra.Length - 1] = Units;
                precioUnidad[precioUnidad.Length - 1] = PrecioUnit;
                totalPago[totalPago.Length - 1] = total;
                Clientes[Clientes.Length - 1] = Customers;

                ListaFacturas.Rows.Add(tbCliente.Text, mcbProductos.Text, tbUnidades.Text, tbPrecioU.Text);

                tbCliente.Text = "";
                mcbProductos.Text = "";
                tbUnidades.Text = "";
                tbPrecioU.Text = "";
                tbTotal.Text = "";

            }

        }

        public bool CamposVacios(Object[] campos, object[] combos = null)
        {
            bool vacio = false;

            for (int i = 0; i < campos.Length; i++)
            {
                MaterialTextBox campo = (MaterialTextBox)campos[i];

                if (string.IsNullOrEmpty(campo.Text))
                {
                    MessageBox.Show($"El campo {campo.Hint} está vacio");
                    vacio = true;
                    break;
                }
            }

            if (combos != null)
            {
                for (int i = 0; i < combos.Length; i++)
                {
                    MaterialComboBox comboBox = (MaterialComboBox)combos[i];
                    if (comboBox.SelectedItem == null)
                    {
                        vacio = true;
                        MessageBox.Show("Debes seleccionar un valor de la lista desplegable");
                        break;
                    }

                }
            }
            return vacio;
        }


    }
}
