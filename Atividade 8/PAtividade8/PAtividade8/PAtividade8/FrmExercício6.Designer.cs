
namespace PAtividade8
{
    partial class FrmExercício6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercício6));
            this.btncalcularmedia = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalcularmedia
            // 
            this.btncalcularmedia.BackColor = System.Drawing.Color.Coral;
            this.btncalcularmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcularmedia.ForeColor = System.Drawing.Color.Azure;
            this.btncalcularmedia.Location = new System.Drawing.Point(283, 301);
            this.btncalcularmedia.Name = "btncalcularmedia";
            this.btncalcularmedia.Size = new System.Drawing.Size(166, 67);
            this.btncalcularmedia.TabIndex = 0;
            this.btncalcularmedia.Text = "Calcular Média";
            this.btncalcularmedia.UseVisualStyleBackColor = false;
            this.btncalcularmedia.Click += new System.EventHandler(this.btncalcularmedia_Click);
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
            this.textBox1.Size = new System.Drawing.Size(433, 192);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Crie uma matriz para guardar as 3 notas de uma disciplina de uma turma de 20 alun" +
    "os. Considere os alunos como as linhas e as notas como as colunas. Receba os dad" +
    "os. Calcule e mostre a média de aluno.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmExercício6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btncalcularmedia);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExercício6";
            this.Text = "Exercício 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcularmedia;
        private System.Windows.Forms.TextBox textBox1;
    }
}