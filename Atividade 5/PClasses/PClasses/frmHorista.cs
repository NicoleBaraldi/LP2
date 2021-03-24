using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void frmHorista_Load(object sender, EventArgs e)
        {

        }

        private void btninstanciar_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();
            

            objHorista.NomeEmpregado = txtnome.Text;
            objHorista.Matricula = Convert.ToInt32(txtmatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtsalarioporhora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtnumerodehoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtdataentrada.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtdiasdefaltas.Text);
            
            MessageBox.Show("Nome:" + objHorista.NomeEmpregado +
                    "\n" + "Matricula:" + objHorista.Matricula + "\n" +
                    "Tempo Trabalho:" + objHorista.TempoTrabalho().ToString()
                   + "\n" + "Salário:" + objHorista.SalarioBruto().ToString("N2"));

        }

        private void btnback_Click(object sender, EventArgs e)
        
            {
                this.Close();
            }
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();

            forma.AddEllipse(0, 0, btnback.Width, btnback.Height);

            btnback.Region = new Region(forma);
        
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtsalarioporhora.Clear();
            txtnumerodehoras.Clear();
            txtdataentrada.Clear();
            txtdiasdefaltas.Clear();
            txtmatricula.Clear();

        }
    }
}
