using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void atividade1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercício1 objFrm1 = new FrmExercício1();
            objFrm1.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm1.WindowState = FormWindowState.Maximized;
            objFrm1.Show();
        }

        private void atividade2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercício2 objFrm1 = new FrmExercício2();
            objFrm1.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm1.WindowState = FormWindowState.Maximized;
            objFrm1.Show();
        }

        private void atividade3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercício3 objFrm1 = new FrmExercício3();
            objFrm1.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm1.WindowState = FormWindowState.Maximized;
            objFrm1.Show();
        }

        private void atividade4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercício4 objFrm1 = new FrmExercício4();
            objFrm1.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm1.WindowState = FormWindowState.Maximized;
            objFrm1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void atividade5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercício5 objFrm1 = new FrmExercício5();
            objFrm1.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm1.WindowState = FormWindowState.Maximized;
            objFrm1.Show();
        }

        private void atividade6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercício6 objFrm1 = new FrmExercício6();
            objFrm1.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm1.WindowState = FormWindowState.Maximized;
            objFrm1.Show();
        }

        private void atividade7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercício7 objFrm1 = new FrmExercício7();
            objFrm1.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm1.WindowState = FormWindowState.Maximized;
            objFrm1.Show();
        }
    }
}
