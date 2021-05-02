
namespace Atividade_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercicio3));
            this.txtpalavra = new System.Windows.Forms.TextBox();
            this.lblpalavra = new System.Windows.Forms.Label();
            this.btnpalindromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpalavra
            // 
            this.txtpalavra.Location = new System.Drawing.Point(128, 111);
            this.txtpalavra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpalavra.Name = "txtpalavra";
            this.txtpalavra.Size = new System.Drawing.Size(238, 22);
            this.txtpalavra.TabIndex = 0;
            this.txtpalavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblpalavra
            // 
            this.lblpalavra.AutoSize = true;
            this.lblpalavra.BackColor = System.Drawing.Color.Indigo;
            this.lblpalavra.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblpalavra.Location = new System.Drawing.Point(56, 114);
            this.lblpalavra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpalavra.Name = "lblpalavra";
            this.lblpalavra.Size = new System.Drawing.Size(56, 17);
            this.lblpalavra.TabIndex = 1;
            this.lblpalavra.Text = "Palavra";
            // 
            // btnpalindromo
            // 
            this.btnpalindromo.BackColor = System.Drawing.Color.Indigo;
            this.btnpalindromo.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnpalindromo.Location = new System.Drawing.Point(197, 194);
            this.btnpalindromo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpalindromo.Name = "btnpalindromo";
            this.btnpalindromo.Size = new System.Drawing.Size(100, 28);
            this.btnpalindromo.TabIndex = 1;
            this.btnpalindromo.Text = "Palíndromo";
            this.btnpalindromo.UseVisualStyleBackColor = false;
            this.btnpalindromo.Click += new System.EventHandler(this.btnpalindromo_Click);
            // 
            // FrmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 327);
            this.Controls.Add(this.btnpalindromo);
            this.Controls.Add(this.lblpalavra);
            this.Controls.Add(this.txtpalavra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(501, 374);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(501, 374);
            this.Name = "FrmExercicio3";
            this.Text = "FrmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpalavra;
        private System.Windows.Forms.Label lblpalavra;
        private System.Windows.Forms.Button btnpalindromo;
    }
}