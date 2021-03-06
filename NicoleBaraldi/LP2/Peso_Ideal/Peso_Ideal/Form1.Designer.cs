
namespace Peso_Ideal
{
    partial class Peso_ideal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peso_ideal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxsexo = new System.Windows.Forms.GroupBox();
            this.btnmasculino = new System.Windows.Forms.RadioButton();
            this.btnfeminino = new System.Windows.Forms.RadioButton();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.mskaltura = new System.Windows.Forms.MaskedTextBox();
            this.mskpeso = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtideal = new System.Windows.Forms.TextBox();
            this.boxsexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura(m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso(Kg)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // boxsexo
            // 
            this.boxsexo.Controls.Add(this.btnmasculino);
            this.boxsexo.Controls.Add(this.btnfeminino);
            this.boxsexo.Location = new System.Drawing.Point(328, 55);
            this.boxsexo.Name = "boxsexo";
            this.boxsexo.Size = new System.Drawing.Size(165, 94);
            this.boxsexo.TabIndex = 2;
            this.boxsexo.TabStop = false;
            this.boxsexo.Text = "Sexo";
            // 
            // btnmasculino
            // 
            this.btnmasculino.AutoSize = true;
            this.btnmasculino.Location = new System.Drawing.Point(7, 59);
            this.btnmasculino.Name = "btnmasculino";
            this.btnmasculino.Size = new System.Drawing.Size(101, 20);
            this.btnmasculino.TabIndex = 5;
            this.btnmasculino.Text = "Masculino";
            this.btnmasculino.UseVisualStyleBackColor = true;
            // 
            // btnfeminino
            // 
            this.btnfeminino.AutoSize = true;
            this.btnfeminino.Checked = true;
            this.btnfeminino.Location = new System.Drawing.Point(7, 33);
            this.btnfeminino.Name = "btnfeminino";
            this.btnfeminino.Size = new System.Drawing.Size(93, 20);
            this.btnfeminino.TabIndex = 4;
            this.btnfeminino.TabStop = true;
            this.btnfeminino.Text = "Feminino";
            this.btnfeminino.UseVisualStyleBackColor = true;
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(128, 148);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(148, 23);
            this.txtresultado.TabIndex = 2;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.LightPink;
            this.btnlimpar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(33, 308);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(135, 40);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.LightPink;
            this.btnsair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsair.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(33, 372);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(135, 37);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.LightPink;
            this.btncalcular.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(33, 250);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(135, 35);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Cacular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // mskaltura
            // 
            this.mskaltura.Location = new System.Drawing.Point(128, 55);
            this.mskaltura.Mask = "0.00";
            this.mskaltura.Name = "mskaltura";
            this.mskaltura.Size = new System.Drawing.Size(148, 23);
            this.mskaltura.TabIndex = 0;
            this.mskaltura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskaltura_MaskInputRejected);
            // 
            // mskpeso
            // 
            this.mskpeso.Location = new System.Drawing.Point(128, 101);
            this.mskpeso.Mask = "000.00";
            this.mskpeso.Name = "mskpeso";
            this.mskpeso.Size = new System.Drawing.Size(148, 23);
            this.mskpeso.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Peso Ideal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtideal
            // 
            this.txtideal.Enabled = false;
            this.txtideal.Location = new System.Drawing.Point(128, 199);
            this.txtideal.Name = "txtideal";
            this.txtideal.Size = new System.Drawing.Size(148, 23);
            this.txtideal.TabIndex = 3;
            // 
            // Peso_ideal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnsair;
            this.ClientSize = new System.Drawing.Size(518, 449);
            this.Controls.Add(this.txtideal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskpeso);
            this.Controls.Add(this.mskaltura);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.boxsexo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Peso_ideal";
            this.Text = "Peso Ideal";
            this.boxsexo.ResumeLayout(false);
            this.boxsexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox boxsexo;
        private System.Windows.Forms.RadioButton btnmasculino;
        private System.Windows.Forms.RadioButton btnfeminino;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.MaskedTextBox mskaltura;
        private System.Windows.Forms.MaskedTextBox mskpeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtideal;
    }
}

