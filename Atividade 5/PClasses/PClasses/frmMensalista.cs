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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btninstancia_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            objMensalista.Matricula = Convert.ToInt32(txtmatricula.Text);
            objMensalista.NomeEmpregado = txtnome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtdataentrada.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtsalariomensal.Text);

            MessageBox.Show("Matrícula    :"              + objMensalista.Matricula + "\n" +
                            "Nome         :"              + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada :"              + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salario Bruto:"              + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo Empresa (dias) : "     + objMensalista.TempoTrabalho());
        
        }

        private void btnparametros_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtmatricula.Text),
                txtnome.Text, Convert.ToDateTime(txtdataentrada.Text),
                Convert.ToDouble(txtsalariomensal.Text));

                 MessageBox.Show("Matrícula    :" + objMensalista.Matricula + "\n" +
                            "Nome         :" + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada :" + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salario Bruto:" + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo Empresa (dias) : " + objMensalista.TempoTrabalho());


        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtdataentrada.Clear();
            txtnome.Clear();
            txtmatricula.Clear();
            txtsalariomensal.Clear();
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
    }
}
