using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peso_Ideal
{
    public partial class Peso_ideal : Form
    {
        public Peso_ideal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskaltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            mskaltura.Clear();
            mskpeso.Clear();
            txtideal.Clear();
            txtresultado.Clear();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, resultado=0;

            if(double.TryParse(mskaltura.Text, out altura) && double.TryParse(mskpeso.Text, out peso))
            {
                if(btnmasculino.Checked)
                {
                    resultado = (72.7 * altura) - 58;
                }
                else if(btnfeminino.Checked)
                {
                    resultado = (62.1 * altura) - 44.7;
                }

                resultado = Math.Round(resultado, 2);
                txtideal.Text = resultado.ToString();

                if (peso == resultado)
                    txtresultado.Text = "Peso ideal!";
                else if (peso > resultado)
                    txtresultado.Text = "Acima do peso ideal";
                else
                    txtresultado.Text = "Abaixo do peso ideal";
            }
            else
            {
                MessageBox.Show("Dados inválidos"); 
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
