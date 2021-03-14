
namespace PSalario
{
    partial class gbxSexo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gbxSexo));
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.lblfilhos = new System.Windows.Forms.Label();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.mskbxFilhos = new System.Windows.Forms.MaskedTextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIR = new System.Windows.Forms.Label();
            this.lblDescontoIR = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtAliquotaIR = new System.Windows.Forms.TextBox();
            this.txtDescontoIR = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtsalarioliquido = new System.Windows.Forms.TextBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.ckbxHomem = new System.Windows.Forms.RadioButton();
            this.ckbxMulher = new System.Windows.Forms.RadioButton();
            this.cboboxEstado = new System.Windows.Forms.ComboBox();
            this.lblestadocivil = new System.Windows.Forms.Label();
            this.mskNome = new System.Windows.Forms.MaskedTextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnVerificar.Location = new System.Drawing.Point(827, 223);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(185, 45);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar Descontos";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.SlateGray;
            this.lblnome.ForeColor = System.Drawing.Color.Snow;
            this.lblnome.Location = new System.Drawing.Point(32, 42);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(159, 21);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome Funcionário";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.BackColor = System.Drawing.Color.SlateGray;
            this.lblsalario.ForeColor = System.Drawing.Color.Snow;
            this.lblsalario.Location = new System.Drawing.Point(32, 105);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(112, 21);
            this.lblsalario.TabIndex = 2;
            this.lblsalario.Text = "Salário Bruto";
            // 
            // lblfilhos
            // 
            this.lblfilhos.AutoSize = true;
            this.lblfilhos.BackColor = System.Drawing.Color.SlateGray;
            this.lblfilhos.ForeColor = System.Drawing.Color.Snow;
            this.lblfilhos.Location = new System.Drawing.Point(32, 162);
            this.lblfilhos.Name = "lblfilhos";
            this.lblfilhos.Size = new System.Drawing.Size(150, 21);
            this.lblfilhos.TabIndex = 3;
            this.lblfilhos.Text = "Número de Filhos";
            this.lblfilhos.Click += new System.EventHandler(this.label3_Click);
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.HidePromptOnLeave = true;
            this.mskbxSalario.Location = new System.Drawing.Point(195, 97);
            this.mskbxSalario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskbxSalario.Mask = "00000.00";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(124, 28);
            this.mskbxSalario.TabIndex = 2;
            // 
            // mskbxFilhos
            // 
            this.mskbxFilhos.HidePromptOnLeave = true;
            this.mskbxFilhos.Location = new System.Drawing.Point(195, 153);
            this.mskbxFilhos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskbxFilhos.Mask = "00";
            this.mskbxFilhos.Name = "mskbxFilhos";
            this.mskbxFilhos.Size = new System.Drawing.Size(124, 28);
            this.mskbxFilhos.TabIndex = 3;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(32, 235);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(104, 21);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.Visible = false;
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.BackColor = System.Drawing.Color.SlateGray;
            this.lblAliquotaINSS.ForeColor = System.Drawing.Color.Snow;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(37, 314);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(120, 21);
            this.lblAliquotaINSS.TabIndex = 8;
            this.lblAliquotaINSS.Text = "Aliquota INSS";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.BackColor = System.Drawing.Color.SlateGray;
            this.lblDescontoINSS.ForeColor = System.Drawing.Color.Snow;
            this.lblDescontoINSS.Location = new System.Drawing.Point(423, 387);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(130, 21);
            this.lblDescontoINSS.TabIndex = 9;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblAliquotaIR
            // 
            this.lblAliquotaIR.AutoSize = true;
            this.lblAliquotaIR.BackColor = System.Drawing.Color.SlateGray;
            this.lblAliquotaIR.ForeColor = System.Drawing.Color.Snow;
            this.lblAliquotaIR.Location = new System.Drawing.Point(37, 380);
            this.lblAliquotaIR.Name = "lblAliquotaIR";
            this.lblAliquotaIR.Size = new System.Drawing.Size(101, 21);
            this.lblAliquotaIR.TabIndex = 10;
            this.lblAliquotaIR.Text = "Aliquota IR";
            // 
            // lblDescontoIR
            // 
            this.lblDescontoIR.AutoSize = true;
            this.lblDescontoIR.BackColor = System.Drawing.Color.SlateGray;
            this.lblDescontoIR.ForeColor = System.Drawing.Color.Snow;
            this.lblDescontoIR.Location = new System.Drawing.Point(427, 314);
            this.lblDescontoIR.Name = "lblDescontoIR";
            this.lblDescontoIR.Size = new System.Drawing.Size(111, 21);
            this.lblDescontoIR.TabIndex = 11;
            this.lblDescontoIR.Text = "Desconto IR";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.BackColor = System.Drawing.Color.SlateGray;
            this.lblSalarioFamilia.ForeColor = System.Drawing.Color.Snow;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(37, 442);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(125, 21);
            this.lblSalarioFamilia.TabIndex = 12;
            this.lblSalarioFamilia.Text = "Salário Família";
            this.lblSalarioFamilia.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(195, 314);
            this.txtAliquotaINSS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(124, 28);
            this.txtAliquotaINSS.TabIndex = 13;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(563, 387);
            this.txtDescontoINSS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(124, 28);
            this.txtDescontoINSS.TabIndex = 14;
            // 
            // txtAliquotaIR
            // 
            this.txtAliquotaIR.Enabled = false;
            this.txtAliquotaIR.Location = new System.Drawing.Point(195, 377);
            this.txtAliquotaIR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAliquotaIR.Name = "txtAliquotaIR";
            this.txtAliquotaIR.Size = new System.Drawing.Size(124, 28);
            this.txtAliquotaIR.TabIndex = 15;
            // 
            // txtDescontoIR
            // 
            this.txtDescontoIR.Enabled = false;
            this.txtDescontoIR.Location = new System.Drawing.Point(563, 314);
            this.txtDescontoIR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescontoIR.Name = "txtDescontoIR";
            this.txtDescontoIR.Size = new System.Drawing.Size(124, 28);
            this.txtDescontoIR.TabIndex = 16;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(195, 442);
            this.txtSalarioFamilia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(124, 28);
            this.txtSalarioFamilia.TabIndex = 17;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.BackColor = System.Drawing.Color.SlateGray;
            this.lblSalarioLiquido.ForeColor = System.Drawing.Color.Snow;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(37, 501);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(128, 21);
            this.lblSalarioLiquido.TabIndex = 18;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // txtsalarioliquido
            // 
            this.txtsalarioliquido.Enabled = false;
            this.txtsalarioliquido.Location = new System.Drawing.Point(195, 501);
            this.txtsalarioliquido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsalarioliquido.Name = "txtsalarioliquido";
            this.txtsalarioliquido.Size = new System.Drawing.Size(124, 28);
            this.txtsalarioliquido.TabIndex = 19;
            // 
            // grpSexo
            // 
            this.grpSexo.BackColor = System.Drawing.Color.SandyBrown;
            this.grpSexo.Controls.Add(this.ckbxHomem);
            this.grpSexo.Controls.Add(this.ckbxMulher);
            this.grpSexo.Location = new System.Drawing.Point(762, 34);
            this.grpSexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSexo.Size = new System.Drawing.Size(250, 131);
            this.grpSexo.TabIndex = 20;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // ckbxHomem
            // 
            this.ckbxHomem.AutoSize = true;
            this.ckbxHomem.Location = new System.Drawing.Point(8, 83);
            this.ckbxHomem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbxHomem.Name = "ckbxHomem";
            this.ckbxHomem.Size = new System.Drawing.Size(95, 25);
            this.ckbxHomem.TabIndex = 1;
            this.ckbxHomem.Text = "Homem";
            this.ckbxHomem.UseVisualStyleBackColor = true;
            // 
            // ckbxMulher
            // 
            this.ckbxMulher.AutoSize = true;
            this.ckbxMulher.BackColor = System.Drawing.Color.Transparent;
            this.ckbxMulher.Checked = true;
            this.ckbxMulher.Location = new System.Drawing.Point(8, 34);
            this.ckbxMulher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbxMulher.Name = "ckbxMulher";
            this.ckbxMulher.Size = new System.Drawing.Size(87, 25);
            this.ckbxMulher.TabIndex = 0;
            this.ckbxMulher.TabStop = true;
            this.ckbxMulher.Text = "Mulher";
            this.ckbxMulher.UseVisualStyleBackColor = false;
            // 
            // cboboxEstado
            // 
            this.cboboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxEstado.FormattingEnabled = true;
            this.cboboxEstado.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)"});
            this.cboboxEstado.Location = new System.Drawing.Point(558, 162);
            this.cboboxEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboboxEstado.Name = "cboboxEstado";
            this.cboboxEstado.Size = new System.Drawing.Size(124, 29);
            this.cboboxEstado.TabIndex = 21;
            // 
            // lblestadocivil
            // 
            this.lblestadocivil.AutoSize = true;
            this.lblestadocivil.BackColor = System.Drawing.Color.SlateGray;
            this.lblestadocivil.ForeColor = System.Drawing.Color.Snow;
            this.lblestadocivil.Location = new System.Drawing.Point(427, 162);
            this.lblestadocivil.Name = "lblestadocivil";
            this.lblestadocivil.Size = new System.Drawing.Size(107, 21);
            this.lblestadocivil.TabIndex = 22;
            this.lblestadocivil.Text = "Estado Civil";
            this.lblestadocivil.Click += new System.EventHandler(this.label4_Click);
            // 
            // mskNome
            // 
            this.mskNome.HidePromptOnLeave = true;
            this.mskNome.Location = new System.Drawing.Point(195, 34);
            this.mskNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskNome.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mskNome.Name = "mskNome";
            this.mskNome.Size = new System.Drawing.Size(487, 28);
            this.mskNome.TabIndex = 1;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.SandyBrown;
            this.btnclear.Location = new System.Drawing.Point(563, 484);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(183, 45);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.SandyBrown;
            this.btnclose.Location = new System.Drawing.Point(829, 484);
            this.btnclose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(183, 45);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "Fechar";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // gbxSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 553);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.mskNome);
            this.Controls.Add(this.lblestadocivil);
            this.Controls.Add(this.cboboxEstado);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.txtsalarioliquido);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtDescontoIR);
            this.Controls.Add(this.txtAliquotaIR);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblDescontoIR);
            this.Controls.Add(this.lblAliquotaIR);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.mskbxFilhos);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.lblfilhos);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btnVerificar);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1072, 600);
            this.MinimumSize = new System.Drawing.Size(1072, 600);
            this.Name = "gbxSexo";
            this.Text = "Meu Salário";
            this.Load += new System.EventHandler(this.gbxSexo_Load);
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.Label lblfilhos;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.MaskedTextBox mskbxFilhos;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblAliquotaIR;
        private System.Windows.Forms.Label lblDescontoIR;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtAliquotaIR;
        private System.Windows.Forms.TextBox txtDescontoIR;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtsalarioliquido;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton ckbxHomem;
        private System.Windows.Forms.RadioButton ckbxMulher;
        private System.Windows.Forms.ComboBox cboboxEstado;
        private System.Windows.Forms.Label lblestadocivil;
        private System.Windows.Forms.MaskedTextBox mskNome;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}

