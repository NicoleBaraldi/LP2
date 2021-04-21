
namespace Ptestemetodos
{
    partial class FrmExercicio4
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
            this.rtfTexto = new System.Windows.Forms.RichTextBox();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtfTexto
            // 
            this.rtfTexto.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfTexto.Location = new System.Drawing.Point(173, 56);
            this.rtfTexto.Margin = new System.Windows.Forms.Padding(4);
            this.rtfTexto.Name = "rtfTexto";
            this.rtfTexto.Size = new System.Drawing.Size(360, 175);
            this.rtfTexto.TabIndex = 0;
            this.rtfTexto.Text = "";
            // 
            // btnNumeros
            // 
            this.btnNumeros.BackColor = System.Drawing.Color.Black;
            this.btnNumeros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumeros.Font = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.btnNumeros.ForeColor = System.Drawing.Color.Azure;
            this.btnNumeros.Location = new System.Drawing.Point(173, 254);
            this.btnNumeros.Margin = new System.Windows.Forms.Padding(4);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(135, 48);
            this.btnNumeros.TabIndex = 1;
            this.btnNumeros.Text = "Numeros";
            this.btnNumeros.UseVisualStyleBackColor = false;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.BackColor = System.Drawing.Color.Black;
            this.btnLetras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLetras.Font = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.btnLetras.ForeColor = System.Drawing.Color.Azure;
            this.btnLetras.Location = new System.Drawing.Point(342, 254);
            this.btnLetras.Margin = new System.Windows.Forms.Padding(4);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(135, 48);
            this.btnLetras.TabIndex = 2;
            this.btnLetras.Text = "Letras";
            this.btnLetras.UseVisualStyleBackColor = false;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.Color.Black;
            this.btnBranco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBranco.Font = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.btnBranco.ForeColor = System.Drawing.Color.Azure;
            this.btnBranco.Location = new System.Drawing.Point(253, 310);
            this.btnBranco.Margin = new System.Windows.Forms.Padding(4);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(135, 48);
            this.btnBranco.TabIndex = 3;
            this.btnBranco.Text = "Espaço em Branco";
            this.btnBranco.UseVisualStyleBackColor = false;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ptestemetodos.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.rtfTexto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "FrmExercicio4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfTexto;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.Button btnBranco;
    }
}