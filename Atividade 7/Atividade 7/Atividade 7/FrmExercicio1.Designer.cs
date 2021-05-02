
namespace Atividade_7
{
    partial class FrmExercicio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercicio1));
            this.btnpardeletras = new System.Windows.Forms.Button();
            this.btnletrar = new System.Windows.Forms.Button();
            this.btnespacoembranco = new System.Windows.Forms.Button();
            this.rtftexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnpardeletras
            // 
            this.btnpardeletras.BackColor = System.Drawing.Color.Indigo;
            this.btnpardeletras.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnpardeletras.Location = new System.Drawing.Point(240, 197);
            this.btnpardeletras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpardeletras.Name = "btnpardeletras";
            this.btnpardeletras.Size = new System.Drawing.Size(153, 27);
            this.btnpardeletras.TabIndex = 7;
            this.btnpardeletras.Text = "Par de Letras";
            this.btnpardeletras.UseVisualStyleBackColor = false;
            this.btnpardeletras.Click += new System.EventHandler(this.btnpardeletras_Click);
            // 
            // btnletrar
            // 
            this.btnletrar.BackColor = System.Drawing.Color.Indigo;
            this.btnletrar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnletrar.Location = new System.Drawing.Point(158, 232);
            this.btnletrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnletrar.Name = "btnletrar";
            this.btnletrar.Size = new System.Drawing.Size(153, 27);
            this.btnletrar.TabIndex = 6;
            this.btnletrar.Text = "Letra \"R\"";
            this.btnletrar.UseVisualStyleBackColor = false;
            this.btnletrar.Click += new System.EventHandler(this.btnletrar_Click);
            // 
            // btnespacoembranco
            // 
            this.btnespacoembranco.BackColor = System.Drawing.Color.Indigo;
            this.btnespacoembranco.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnespacoembranco.Location = new System.Drawing.Point(80, 197);
            this.btnespacoembranco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnespacoembranco.Name = "btnespacoembranco";
            this.btnespacoembranco.Size = new System.Drawing.Size(153, 27);
            this.btnespacoembranco.TabIndex = 5;
            this.btnespacoembranco.Text = "Espaço em branco";
            this.btnespacoembranco.UseVisualStyleBackColor = false;
            this.btnespacoembranco.Click += new System.EventHandler(this.btnespacoembranco_Click);
            // 
            // rtftexto
            // 
            this.rtftexto.Location = new System.Drawing.Point(80, 52);
            this.rtftexto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtftexto.Name = "rtftexto";
            this.rtftexto.Size = new System.Drawing.Size(313, 137);
            this.rtftexto.TabIndex = 4;
            this.rtftexto.Text = "";
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 327);
            this.Controls.Add(this.btnpardeletras);
            this.Controls.Add(this.btnletrar);
            this.Controls.Add(this.btnespacoembranco);
            this.Controls.Add(this.rtftexto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(501, 374);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(501, 374);
            this.Name = "FrmExercicio1";
            this.Text = "FrmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpardeletras;
        private System.Windows.Forms.Button btnletrar;
        private System.Windows.Forms.Button btnespacoembranco;
        private System.Windows.Forms.RichTextBox rtftexto;
    }
}