
namespace PAtividade8
{
    partial class FrmExercício2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercício2));
            this.btnExibirNumeros = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExibirNumeros
            // 
            this.btnExibirNumeros.BackColor = System.Drawing.Color.Coral;
            this.btnExibirNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirNumeros.ForeColor = System.Drawing.Color.Azure;
            this.btnExibirNumeros.Location = new System.Drawing.Point(283, 301);
            this.btnExibirNumeros.Name = "btnExibirNumeros";
            this.btnExibirNumeros.Size = new System.Drawing.Size(166, 67);
            this.btnExibirNumeros.TabIndex = 0;
            this.btnExibirNumeros.Text = "Exibir Números";
            this.btnExibirNumeros.UseVisualStyleBackColor = false;
            this.btnExibirNumeros.Click += new System.EventHandler(this.btnExibirNumeros_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MintCream;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox1.Location = new System.Drawing.Point(150, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 135);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Faça um programa que carregue uma lista 20 números, colocando-os em um vetor, apó" +
    "s o carregamento mostre-os na ordem inversa. (Reverse)";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmExercício2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExibirNumeros);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(751, 497);
            this.MinimumSize = new System.Drawing.Size(751, 497);
            this.Name = "FrmExercício2";
            this.Text = "Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExibirNumeros;
        private System.Windows.Forms.TextBox textBox1;
    }
}