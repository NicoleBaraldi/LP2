using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_Triângulos
{
    public partial class Calculo_Triangulo : Form
    {
        public Calculo_Triangulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            mska.Clear();
            mskb.Clear();

            mskc.Text = String.Empty;

            txtresultado.Text = "";
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double ladoa, ladob, ladoc;

            if (double.TryParse(mska.Text, out ladoa)&&
                double.TryParse(mskb.Text, out ladob)&&
                double.TryParse(mskc.Text, out ladoc))
            {
                if ((Math.Abs(ladob - ladoc) < ladoa && ladoa < (ladob + ladoc)) && 
                    (Math.Abs(ladoa - ladoc) < ladob && ladob < (ladoa + ladoc)) &&
                    (Math.Abs(ladoa - ladob) < ladoc && ladoc < (ladoa + ladob)))
                {
                    if (ladoa == ladob && ladoa == ladoc)
                        txtresultado.Text = "Triângulo Equilátero";
                    else if (ladoa == ladob && ladoa != ladoc)
                        txtresultado.Text = "Triângulo Isosceles";
                    else
                        txtresultado.Text = "Triângulo Escaleno";
                }
                else
                {
                    txtresultado.Text = "Não foi possível formar um triângulo";
                }
            }
            else
            {
                MessageBox.Show("Insira novamente os dados","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Calculo_Triangulo_Load(object sender, EventArgs e)
        {

        }
    }
}
