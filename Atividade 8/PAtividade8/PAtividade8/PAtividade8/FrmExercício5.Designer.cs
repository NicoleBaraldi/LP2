
namespace PAtividade8
{
    partial class FrmExercício5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercício5));
            this.btnImprimirNomes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnImprimirNomes
            // 
            this.btnImprimirNomes.BackColor = System.Drawing.Color.Coral;
            this.btnImprimirNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirNomes.ForeColor = System.Drawing.Color.Azure;
            this.btnImprimirNomes.Location = new System.Drawing.Point(283, 301);
            this.btnImprimirNomes.Name = "btnImprimirNomes";
            this.btnImprimirNomes.Size = new System.Drawing.Size(166, 67);
            this.btnImprimirNomes.TabIndex = 0;
            this.btnImprimirNomes.Text = "Imprimir Nomes";
            this.btnImprimirNomes.UseVisualStyleBackColor = false;
            this.btnImprimirNomes.Click += new System.EventHandler(this.btnImprimirNomes_Click);
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
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Faça um programa que carregue a seguinte lista de alunos em um array : Ana, André" +
    ", Débora, Fátima, João, Janete, Otávio, Marcelo, Pedro, Thais.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmExercício5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnImprimirNomes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(751, 497);
            this.MinimumSize = new System.Drawing.Size(751, 497);
            this.Name = "FrmExercício5";
            this.Text = "Exercício 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimirNomes;
        private System.Windows.Forms.TextBox textBox1;
    }
}