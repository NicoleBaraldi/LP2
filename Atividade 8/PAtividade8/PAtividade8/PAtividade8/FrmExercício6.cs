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
    public partial class FrmExercício6 : Form
    {
        public FrmExercício6()
        {
            InitializeComponent();
        }

        private void btncalcularmedia_Click(object sender, EventArgs e)
        {
            int linha = 20;
            int coluna = 3;

            double[,] notas = new double[linha, coluna];

            double[] notaAluno = new double[linha];

            string saida = "";

            for(int i=0; i<linha; i++)
            {
                notaAluno[i] = 0;

                for (int j = 0; j < coluna; j++)
                {
                    var nota = Interaction.InputBox($"Nota #{j+1}", $"Entre com a nota do aluno {i + 1}");

                    if( !double.TryParse(nota, out notas[i,j]))
                    {
                        MessageBox.Show("Nota inválida");
                        j--;
                        continue;
                    }

                notaAluno[i] += notas[i, j];

                }

                notaAluno[i] = notaAluno[i] / 3.0;
                saida += $"Aluno{i + 1}: média: {notaAluno[i]:N2} \n";
            }

            MessageBox.Show(saida);
        }

    }
}
