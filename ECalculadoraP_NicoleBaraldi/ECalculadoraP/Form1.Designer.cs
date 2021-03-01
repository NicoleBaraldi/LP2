
namespace ECalculadoraP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmpy = new System.Windows.Forms.Button();
            this.btnquit = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(26, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1 ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Location = new System.Drawing.Point(26, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Location = new System.Drawing.Point(26, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(24, 142);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(97, 29);
            this.txtnum1.TabIndex = 9;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.OldLace;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadd.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnadd.Location = new System.Drawing.Point(328, 137);
            this.btnadd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 30);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.Color.OldLace;
            this.btnsub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsub.Location = new System.Drawing.Point(328, 191);
            this.btnsub.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(111, 30);
            this.btnsub.TabIndex = 13;
            this.btnsub.Text = "SUB";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.OldLace;
            this.btndiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndiv.Location = new System.Drawing.Point(328, 294);
            this.btndiv.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(111, 27);
            this.btndiv.TabIndex = 14;
            this.btndiv.Text = "DIV";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmpy
            // 
            this.btnmpy.BackColor = System.Drawing.Color.OldLace;
            this.btnmpy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmpy.Location = new System.Drawing.Point(328, 245);
            this.btnmpy.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnmpy.Name = "btnmpy";
            this.btnmpy.Size = new System.Drawing.Size(111, 27);
            this.btnmpy.TabIndex = 15;
            this.btnmpy.Text = "MPY";
            this.btnmpy.UseVisualStyleBackColor = false;
            this.btnmpy.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnquit
            // 
            this.btnquit.BackColor = System.Drawing.Color.OldLace;
            this.btnquit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnquit.Location = new System.Drawing.Point(173, 417);
            this.btnquit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(111, 30);
            this.btnquit.TabIndex = 16;
            this.btnquit.Text = "Quit";
            this.btnquit.UseVisualStyleBackColor = false;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.OldLace;
            this.btnclean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnclean.Location = new System.Drawing.Point(173, 361);
            this.btnclean.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(111, 30);
            this.btnclean.TabIndex = 17;
            this.btnclean.Text = "Clean";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(24, 308);
            this.txtresult.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(97, 29);
            this.txtresult.TabIndex = 18;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(26, 222);
            this.txtnum2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(97, 29);
            this.txtnum2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("PMingLiU-ExtB", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(89, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "CALCULADORA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(454, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.btnmpy);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmpy;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label label4;
    }
}

