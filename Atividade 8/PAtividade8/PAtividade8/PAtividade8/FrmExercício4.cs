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
    public partial class FrmExercício4 : Form
    {
        public FrmExercício4()
        {
            InitializeComponent();
        }

        private void btnContarLetras_Click(object sender, EventArgs e)
        {
            string[] Alunos =
            {"Viviane",
             "André",
             "Hélio",
             "Denise",
             "Júnior",
             "Leonardo",
             "José",
             "Nelma",
             "Tobby" };

            Int32 I, Total = 0;
            Int32 N = Alunos.Length;

            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }
            MessageBox.Show("A resposta é = " + Total);
        }
    }
}
