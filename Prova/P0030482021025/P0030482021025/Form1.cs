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

namespace P0030482021025
{
    public partial class FrmProva : Form
    {
        public FrmProva()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] Valores = new double[5, 4];
            double[] TotalMes = new double[5];
            string valor;
            double totalMeses = 0;

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    valor = Interaction.InputBox("Favor, digite o valor da semana " + (y + 1) + " Do Mês: " + (x + 1), "Digite os dados");
                    if (valor == "")
                    {
                        MessageBox.Show("O campo está vazio!");
                        y--;
                    }
                    else if (double.TryParse(valor, out Valores[x, y]))
                    {
                        double.TryParse(valor, out Valores[x, y]);
                    }
                    else
                    {
                        MessageBox.Show("Favor, digitar apenas números!");
                        y--;
                    }
                }
            }

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    TotalMes[x] = TotalMes[x] + Valores[x, y];
                }
                totalMeses = totalMeses + TotalMes[x];
            }

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    lstExibir.Items.Add("Total do Mês: " + (x + 1) + " Semana: " + (y + 1) + ": R$" + Valores[x, y].ToString("N2"));
                }
                lstExibir.Items.Add("->Total Mensal: R$" + TotalMes[x].ToString("N2"));
                lstExibir.Items.Add("--------------------------------------------------------------");
            }
            lstExibir.Items.Add("Total Geral: R$" + totalMeses.ToString("N2"));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstExibir.Items.Clear();
        }
    }
}
