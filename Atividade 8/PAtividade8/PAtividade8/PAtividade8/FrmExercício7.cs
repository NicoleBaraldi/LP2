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
    public partial class FrmExercício7 : Form
    {
        public FrmExercício7()
        {
            InitializeComponent();
        }

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[5];
            int[] letras = new int[nomes.Length];

            for (int i=0; i<nomes.Length; i++)
            {
                var leitura = Interaction.InputBox($"Digite o #{i+1} nome", "Leitura de Nomes");

                if( string.IsNullOrEmpty(leitura))
                {
                    MessageBox.Show("Nome inválido");
                    i--;
                    continue;
                }

                nomes[i] = leitura;
                int quantidade = 0;

                foreach(char letra in nomes[i])
                {
                    if (letra != ' ')
                        quantidade++;
                }

                letras[i] = quantidade;
            }
            for(int i=0; i<nomes.Length; i++)
            {
                listnomes.Items.Add($"O nome {nomes[i]} possui {letras[i]} caracteres \n");
            }
        }
    }
}
