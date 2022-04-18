using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        Operando num1 = new Operando();

        Operando num2 = new Operando();
        public FormCalculadora()
        {
            InitializeComponent();
           // cmbOperador.SelectedItem = " ";
            StartPosition = FormStartPosition.CenterScreen;
            txtResultado.Text = " ";
          
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lstoperaciones.Items.Clear();
            txtResultado.Text = " ";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            if (txtNumero1.Text != null && txtNumero2.Text != null)
            {
               if (cmbOperador.Text != "+" && cmbOperador.Text != "-" && cmbOperador.Text != "/" && cmbOperador.Text != "*")
                {
                    cmbOperador.Text = "+";
                }
                resultado = Calculadora.Operar(num1, num2,Char.Parse(cmbOperador.Text));
                txtResultado.Text = resultado.ToString();

                //listCalculos.Items.Add(txtOperando1.Text + " " + txtOperando2.Text + " = " + resultado);
                if (txtNumero1.Text == "" && txtNumero2.Text == "")
                {
                    txtNumero1.Text = "0";
                    txtNumero2.Text = "0";
                }
                lstoperaciones.Items.Add($"{txtNumero1.Text}{cmbOperador.Text}{txtNumero2.Text} = {resultado}");
            }
                
        }

       /* private static double Operar(string numero1, string numero2, string operador)
        {
            Operando newOperando1 = new Operando (numero1);
            Operando newOperando2 = new Operando (numero2);
            return Calculadora.Operar(newOperando1,newOperando2, Char.Parse(operador));

        }*/

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            btnLimpiar_Click(sender, e);
        }

        /// <summary>
        /// si el texto cambia, guarda su valor en la propiedad Numero del objeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOperando1_TextChanged(object sender, EventArgs e)
        {
            num1.Numero = this.txtNumero1.Text;

        }

        /// <summary>
        /// si el texto cambia, guarda su valor en la propiedad Numero del objeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            num2.Numero = this.txtNumero2.Text;
        }

        /// <summary>
        /// Muestra el mensaje personalizado, genera los botones, y el icono de pregunta.
        /// si el resultado del dialogo es "si", cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string mensaje = "Estas seguro de que queres cerrar?";
            const string comentario = "Formulario cerrandose";
            var result = MessageBox.Show(mensaje, comentario, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// valida que el resultado no este vacio.
        /// de ser asi, convierte el contenido de Resultado y evalua si se puede convertir a double.
        /// 
        /// si validacion == true, convierte a binario con DecimalBinario
        /// lista el calculo e imprime resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecimalBinario_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            string binario;
            bool validacion = false;
            if (txtResultado.Text != " ")
            {
                validacion = double.TryParse(txtResultado.Text, out resultado);
                // si validacion == true
                if (validacion)
                {
                    binario = Calculadora.DecimalBinario(resultado);
                    lstoperaciones.Items.Add(binario);
                    txtResultado.Text = binario;
                }
            }
        }
        /// <summary>
        /// Convierte el binario guardado en el label resultado a decimal.
        /// Pasa por BinarioDecimal el contenido del label del resultado, 
        /// y agrega el calculo a la lista
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBinarioDecimal_Click(object sender, EventArgs e)
        {
            string numDecimal;
            if (txtResultado.Text != " ")
            {
                numDecimal = Calculadora.BinarioDecimal(txtResultado.Text);
                txtResultado.Text = numDecimal;
                lstoperaciones.Items.Add(numDecimal);
            }


        }
    }
}
