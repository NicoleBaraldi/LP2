
namespace PAtividade8
{
    partial class FrmExercício7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercício7));
            this.btnexecutar = new System.Windows.Forms.Button();
            this.listnomes = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnexecutar
            // 
            this.btnexecutar.BackColor = System.Drawing.Color.Coral;
            this.btnexecutar.ForeColor = System.Drawing.Color.Azure;
            this.btnexecutar.Location = new System.Drawing.Point(150, 296);
            this.btnexecutar.Name = "btnexecutar";
            this.btnexecutar.Size = new System.Drawing.Size(166, 67);
            this.btnexecutar.TabIndex = 0;
            this.btnexecutar.Text = "Executar";
            this.btnexecutar.UseVisualStyleBackColor = false;
            this.btnexecutar.Click += new System.EventHandler(this.btnexecutar_Click);
            // 
            // listnomes
            // 
            this.listnomes.FormattingEnabled = true;
            this.listnomes.ItemHeight = 16;
            this.listnomes.Location = new System.Drawing.Point(322, 296);
            this.listnomes.Name = "listnomes";
            this.listnomes.Size = new System.Drawing.Size(262, 68);
            this.listnomes.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MintCream;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox1.Location = new System.Drawing.Point(150, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 254);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmExercício7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listnomes);
            this.Controls.Add(this.btnexecutar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(751, 497);
            this.MinimumSize = new System.Drawing.Size(751, 497);
            this.Name = "FrmExercício7";
            this.Text = "Exercício 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexecutar;
        private System.Windows.Forms.ListBox listnomes;
        private System.Windows.Forms.TextBox textBox1;
    }
}