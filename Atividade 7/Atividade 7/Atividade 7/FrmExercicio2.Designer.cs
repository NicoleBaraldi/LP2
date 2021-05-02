
namespace Atividade_7
{
    partial class FrmExercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercicio2));
            this.txtnumN = new System.Windows.Forms.TextBox();
            this.txtnumH = new System.Windows.Forms.TextBox();
            this.lblnumN = new System.Windows.Forms.Label();
            this.lblnumH = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumN
            // 
            this.txtnumN.Location = new System.Drawing.Point(240, 80);
            this.txtnumN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumN.Name = "txtnumN";
            this.txtnumN.Size = new System.Drawing.Size(132, 22);
            this.txtnumN.TabIndex = 0;
            // 
            // txtnumH
            // 
            this.txtnumH.Enabled = false;
            this.txtnumH.Location = new System.Drawing.Point(240, 158);
            this.txtnumH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumH.Name = "txtnumH";
            this.txtnumH.Size = new System.Drawing.Size(132, 22);
            this.txtnumH.TabIndex = 1;
            // 
            // lblnumN
            // 
            this.lblnumN.AutoSize = true;
            this.lblnumN.BackColor = System.Drawing.Color.Indigo;
            this.lblnumN.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblnumN.Location = new System.Drawing.Point(135, 80);
            this.lblnumN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumN.Name = "lblnumN";
            this.lblnumN.Size = new System.Drawing.Size(72, 17);
            this.lblnumN.TabIndex = 2;
            this.lblnumN.Text = "Número N";
            // 
            // lblnumH
            // 
            this.lblnumH.AutoSize = true;
            this.lblnumH.BackColor = System.Drawing.Color.Indigo;
            this.lblnumH.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblnumH.Location = new System.Drawing.Point(135, 158);
            this.lblnumH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumH.Name = "lblnumH";
            this.lblnumH.Size = new System.Drawing.Size(72, 17);
            this.lblnumH.TabIndex = 3;
            this.lblnumH.Text = "Número H";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Indigo;
            this.btncalcular.ForeColor = System.Drawing.Color.GhostWhite;
            this.btncalcular.Location = new System.Drawing.Point(182, 228);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(100, 28);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // FrmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 327);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblnumH);
            this.Controls.Add(this.lblnumN);
            this.Controls.Add(this.txtnumH);
            this.Controls.Add(this.txtnumN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(501, 374);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(501, 374);
            this.Name = "FrmExercicio2";
            this.Text = "FrmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumN;
        private System.Windows.Forms.TextBox txtnumH;
        private System.Windows.Forms.Label lblnumN;
        private System.Windows.Forms.Label lblnumH;
        private System.Windows.Forms.Button btncalcular;
    }
}