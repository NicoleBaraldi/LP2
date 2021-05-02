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
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
        }

        private void btnespacoembranco_Click(object sender, EventArgs e)
        {
            int Brancos = 0;

            foreach (char letra in rtftexto.Text)
            {
                if(letra == ' ')
                {
                    Brancos++;
                }
            }

            MessageBox.Show(Brancos.ToString());
        }

        private void btnletrar_Click(object sender, EventArgs e)
        {
            int R = 0;
            
            foreach(char letra in rtftexto.Text)
            {
                if (char.ToUpper(letra) == 'R')
                {
                    R++;
                }
            }
            MessageBox.Show(R.ToString());
        }

        private void btnpardeletras_Click(object sender, EventArgs e)
        {

            int Pares = 0;
            string texto = rtftexto.Text;

            for (int letra=0; letra<texto.Length-1; letra++)
            {
            
                if(texto[letra] == texto[letra+1])
                {
                    Pares++;
                }
            }

            MessageBox.Show(Pares.ToString());
        }
    }
}
