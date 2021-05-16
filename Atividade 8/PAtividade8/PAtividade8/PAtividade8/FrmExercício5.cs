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
    public partial class FrmExercício5 : Form
    {
        public FrmExercício5()
        {
            InitializeComponent();
        }

        private void btnImprimirNomes_Click(object sender, EventArgs e)
        {
            List<string> Nomes = new List<string>()
            {
                "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"
            };

            Nomes.Remove("Otávio");

            string saida = "";

            foreach(string nome in Nomes)
            {
                saida += nome + "\n";
            }
            MessageBox.Show(saida);

             

        }
    }
}
