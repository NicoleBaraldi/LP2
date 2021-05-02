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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnpalindromo_Click(object sender, EventArgs e)
        {
            string texto = txtpalavra.Text;

            texto = texto.Replace(" ", "");

            texto = texto.ToUpper();

            string textoInvertido = new string(texto.Reverse().ToArray());

            if (texto == textoInvertido)
            {
                MessageBox.Show("É um palindromo!");

            }
            else
                MessageBox.Show("Não é palíndromo!");
        }
    }
}
