using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PAtividade8
{
    public partial class FrmExercício3 : Form
    {
        public FrmExercício3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] quantidade = new int[3];
            double[] valor = new double[3];
            double total = 0;

            for (int i = 0; i < quantidade.Length; i++)
            {
                var leitura = Interaction.InputBox($"Quantidade vendida do item {i + 1} ", "Recebendo Informação");

                if (!int.TryParse(leitura, out quantidade[i]))
                {
                    MessageBox.Show("Valor inválido");
                    i--;
                    continue;
                }

                leitura = Interaction.InputBox($"Valor do item {i + 1} ", "Recebendo Informação");

                if (!double.TryParse(leitura, out valor[i]))
                {
                    MessageBox.Show("Valor inválido");
                    i--;
                    continue;
                }

                total = total + (quantidade[i] * valor[i]);
            }
            MessageBox.Show("Total Faturado = R$ " + total);
        }
    }
}
