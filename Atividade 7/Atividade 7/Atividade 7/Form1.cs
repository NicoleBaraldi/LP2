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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            FrmExercicio1 objFrm1 = new FrmExercicio1();
            objFrm1.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm1.WindowState = FormWindowState.Maximized;
            objFrm1.Show();

            
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            FrmExercicio2 objFrm2 = new FrmExercicio2();
            objFrm2.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm2.WindowState = FormWindowState.Maximized;
            objFrm2.Show();

           
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            FrmExercicio3 objFrm3 = new FrmExercicio3();
            objFrm3.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();

           
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            FrmExercicio4 objFrm4 = new FrmExercicio4();
            objFrm4.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm4.WindowState = FormWindowState.Maximized;
            objFrm4.Show();

            
        }
    }
}
