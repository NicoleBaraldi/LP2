﻿
namespace Ptestemetodos
{
    partial class FrmExercicio5
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
            this.btnSorteio = new System.Windows.Forms.Button();
            this.TxtN1 = new System.Windows.Forms.TextBox();
            this.TxtN2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSorteio
            // 
            this.btnSorteio.BackColor = System.Drawing.Color.Black;
            this.btnSorteio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSorteio.Font = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.btnSorteio.ForeColor = System.Drawing.Color.Azure;
            this.btnSorteio.Location = new System.Drawing.Point(396, 67);
            this.btnSorteio.Margin = new System.Windows.Forms.Padding(4);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(135, 48);
            this.btnSorteio.TabIndex = 0;
            this.btnSorteio.Text = "Sorteio";
            this.btnSorteio.UseVisualStyleBackColor = false;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // TxtN1
            // 
            this.TxtN1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN1.Location = new System.Drawing.Point(283, 149);
            this.TxtN1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtN1.Name = "TxtN1";
            this.TxtN1.Size = new System.Drawing.Size(248, 34);
            this.TxtN1.TabIndex = 1;
            // 
            // TxtN2
            // 
            this.TxtN2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.TxtN2.Location = new System.Drawing.Point(283, 199);
            this.TxtN2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtN2.Name = "TxtN2";
            this.TxtN2.Size = new System.Drawing.Size(248, 34);
            this.TxtN2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(173, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(173, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero2";
            // 
            // FrmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ptestemetodos.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtN2);
            this.Controls.Add(this.TxtN1);
            this.Controls.Add(this.btnSorteio);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "FrmExercicio5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSorteio;
        private System.Windows.Forms.TextBox TxtN1;
        private System.Windows.Forms.TextBox TxtN2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}