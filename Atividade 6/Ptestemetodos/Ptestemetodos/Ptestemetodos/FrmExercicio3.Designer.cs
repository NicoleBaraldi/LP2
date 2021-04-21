
namespace Ptestemetodos
{
    partial class FrmExercicio3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPalavra1 = new System.Windows.Forms.TextBox();
            this.TxtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnRemover1 = new System.Windows.Forms.Button();
            this.btnRemover2 = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(175, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(175, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palavra 2";
            // 
            // TxtPalavra1
            // 
            this.TxtPalavra1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPalavra1.Location = new System.Drawing.Point(262, 66);
            this.TxtPalavra1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPalavra1.Name = "TxtPalavra1";
            this.TxtPalavra1.Size = new System.Drawing.Size(274, 34);
            this.TxtPalavra1.TabIndex = 2;
            // 
            // TxtPalavra2
            // 
            this.TxtPalavra2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPalavra2.Location = new System.Drawing.Point(262, 187);
            this.TxtPalavra2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPalavra2.Name = "TxtPalavra2";
            this.TxtPalavra2.Size = new System.Drawing.Size(274, 34);
            this.TxtPalavra2.TabIndex = 3;
            // 
            // btnRemover1
            // 
            this.btnRemover1.BackColor = System.Drawing.Color.Black;
            this.btnRemover1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover1.Font = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.btnRemover1.ForeColor = System.Drawing.Color.Azure;
            this.btnRemover1.Location = new System.Drawing.Point(348, 261);
            this.btnRemover1.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover1.Name = "btnRemover1";
            this.btnRemover1.Size = new System.Drawing.Size(135, 48);
            this.btnRemover1.TabIndex = 4;
            this.btnRemover1.Text = "Remover ocorrências ";
            this.btnRemover1.UseVisualStyleBackColor = false;
            this.btnRemover1.Click += new System.EventHandler(this.btnRemover1_Click);
            // 
            // btnRemover2
            // 
            this.btnRemover2.BackColor = System.Drawing.Color.Black;
            this.btnRemover2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnRemover2.ForeColor = System.Drawing.Color.Azure;
            this.btnRemover2.Location = new System.Drawing.Point(227, 317);
            this.btnRemover2.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover2.Name = "btnRemover2";
            this.btnRemover2.Size = new System.Drawing.Size(204, 48);
            this.btnRemover2.TabIndex = 5;
            this.btnRemover2.Text = "Remover ocorrência (Replace)";
            this.btnRemover2.UseVisualStyleBackColor = false;
            this.btnRemover2.Click += new System.EventHandler(this.btnRemover2_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.BackColor = System.Drawing.Color.Black;
            this.btnInverte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInverte.Font = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.btnInverte.ForeColor = System.Drawing.Color.Azure;
            this.btnInverte.Location = new System.Drawing.Point(179, 261);
            this.btnInverte.Margin = new System.Windows.Forms.Padding(4);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(135, 48);
            this.btnInverte.TabIndex = 6;
            this.btnInverte.Text = "Inverte";
            this.btnInverte.UseVisualStyleBackColor = false;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // FrmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ptestemetodos.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnRemover2);
            this.Controls.Add(this.btnRemover1);
            this.Controls.Add(this.TxtPalavra2);
            this.Controls.Add(this.TxtPalavra1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "FrmExercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExercicio3";
            this.Load += new System.EventHandler(this.FrmExercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPalavra1;
        private System.Windows.Forms.TextBox TxtPalavra2;
        private System.Windows.Forms.Button btnRemover1;
        private System.Windows.Forms.Button btnRemover2;
        private System.Windows.Forms.Button btnInverte;
    }
}