using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class gbxSexo : Form
    {
        public gbxSexo()
        {
            InitializeComponent();
            cboboxEstado.SelectedIndex = 0;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            double salarioBruto = 0;

            if ((mskNome.Text == "") || (mskNome.Text.Length < 5))
                MessageBox.Show("Nome inválido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!double.TryParse(mskbxSalario.Text, out salarioBruto))
                MessageBox.Show("Salário inválido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                double descontoInss = 0, descontoIRPF = 0, salariofamilia = 0, salarioliquido=0;
                byte numeroFilhos = 0;

                if (double.TryParse(mskbxSalario.Text, out salarioBruto) &&
                     byte.TryParse(mskbxFilhos.Text, out numeroFilhos)
                    )
                {
                    if (salarioBruto <= 800.47)
                    {
                        txtAliquotaINSS.Text = "7.65%";
                        descontoInss = 7.65 / 100 * salarioBruto;
                    }
                    else if (salarioBruto <= 1050)
                    {
                        txtAliquotaINSS.Text = "8.65%";
                        descontoInss = 8.65 / 100 * salarioBruto;
                    }
                    else if (salarioBruto <= 1400.77)
                    {
                        txtAliquotaINSS.Text = "9.00%";
                        descontoInss = 9 / 100 * salarioBruto;
                    }
                    else if (salarioBruto <= 2801.56)
                    {
                        txtAliquotaINSS.Text = "11.00%";
                        descontoInss = 11 / 100 * salarioBruto;
                    }
                    else
                    {
                        txtAliquotaINSS.Text = "308,17";
                        descontoInss = 308.17;
                    }


                    if (salarioBruto <= 1257.12)
                    {
                        this.txtAliquotaIR.Text = "Isento";
                    }
                    else if (salarioBruto <= 2512.08)
                    {
                        this.txtAliquotaIR.Text = "15.00%";
                        descontoIRPF = 15.00 / 100 * salarioBruto;
                    }
                    else
                    {
                        this.txtAliquotaIR.Text = "27.05%";
                        descontoIRPF = 27.05 / 100 * salarioBruto;
                    }


                    if (salarioBruto <= 435.52)
                    {
                        salariofamilia = numeroFilhos * 22.33;
                    }
                    else if (salarioBruto <= 652.51)
                    {
                        salariofamilia = numeroFilhos * 15.74;
                    }


                    salarioliquido = salarioBruto - descontoInss - descontoIRPF + salariofamilia;

                    this.txtDescontoINSS.Text = descontoInss.ToString("N2");
                    this.txtDescontoIR.Text = descontoIRPF.ToString("N2");
                    this.txtSalarioFamilia.Text = salariofamilia.ToString("N2");
                    this.txtsalarioliquido.Text = salarioliquido.ToString("N2");

                    string stringona = "Os descontos do salário" ;

                    if (this.ckbxHomem.Checked)
                        stringona = stringona + " do Sr." ;
                    else
                        stringona += " da Sra.";
                    stringona += this.mskNome.Text + " que é" ;

                    if (this.cboboxEstado.SelectedIndex == 1)
                        stringona += " casado(a)  ";
                    else
                        stringona += " solteiro(a) e que tem  ";
                    stringona += this.mskbxFilhos.Text + "  filho(s) são:" ;

                    this.lblMensagem.Text = stringona;


                }
                else
                {
                    MessageBox.Show("Favor, verificar os dados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void gbxSexo_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void btnclear_Click(object sender, EventArgs e)
        {
            this.mskNome.Clear();
            this.mskbxFilhos.Clear();
            this.mskbxSalario.Clear();

            this.txtAliquotaINSS.Clear();
            this.txtAliquotaIR.Clear();
            this.txtDescontoINSS.Clear();
            this.txtDescontoIR.Clear();
            this.txtSalarioFamilia.Clear();
            this.txtsalarioliquido.Clear();
            this.lblMensagem.Text =" ";

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

