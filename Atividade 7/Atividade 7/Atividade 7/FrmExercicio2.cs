using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_7
{
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            if(int.TryParse(txtnumN.Text, out int N))
            {
                if(N > 0)
                {
                    double H = 1;

                    while(N > 0 )
                    {
                        H += 1.0 / N;

                        N--;
                    }

                    txtnumH.Text = H.ToString("N2");
                }
                else
                {

                    MessageBox.Show("O número precisa ser maior que 0!");

                }

            }
            else
            {
                MessageBox.Show("Não foi possível realizar a conversão");
            }

        }
    }
}
