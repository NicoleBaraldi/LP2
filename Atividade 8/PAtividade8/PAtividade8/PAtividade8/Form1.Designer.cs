
namespace PAtividade8
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividade1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividade1ToolStripMenuItem,
            this.atividade2ToolStripMenuItem,
            this.atividade3ToolStripMenuItem,
            this.atividade4ToolStripMenuItem,
            this.atividade5ToolStripMenuItem,
            this.atividade6ToolStripMenuItem,
            this.atividade7ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // atividade1ToolStripMenuItem
            // 
            this.atividade1ToolStripMenuItem.Name = "atividade1ToolStripMenuItem";
            this.atividade1ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.atividade1ToolStripMenuItem.Text = "Atividade 1";
            this.atividade1ToolStripMenuItem.Click += new System.EventHandler(this.atividade1ToolStripMenuItem_Click);
            // 
            // atividade2ToolStripMenuItem
            // 
            this.atividade2ToolStripMenuItem.Name = "atividade2ToolStripMenuItem";
            this.atividade2ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.atividade2ToolStripMenuItem.Text = "Atividade 2";
            this.atividade2ToolStripMenuItem.Click += new System.EventHandler(this.atividade2ToolStripMenuItem_Click);
            // 
            // atividade3ToolStripMenuItem
            // 
            this.atividade3ToolStripMenuItem.Name = "atividade3ToolStripMenuItem";
            this.atividade3ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.atividade3ToolStripMenuItem.Text = "Atividade 3";
            this.atividade3ToolStripMenuItem.Click += new System.EventHandler(this.atividade3ToolStripMenuItem_Click);
            // 
            // atividade4ToolStripMenuItem
            // 
            this.atividade4ToolStripMenuItem.Name = "atividade4ToolStripMenuItem";
            this.atividade4ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.atividade4ToolStripMenuItem.Text = "Atividade 4";
            this.atividade4ToolStripMenuItem.Click += new System.EventHandler(this.atividade4ToolStripMenuItem_Click);
            // 
            // atividade5ToolStripMenuItem
            // 
            this.atividade5ToolStripMenuItem.Name = "atividade5ToolStripMenuItem";
            this.atividade5ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.atividade5ToolStripMenuItem.Text = "Atividade 5";
            this.atividade5ToolStripMenuItem.Click += new System.EventHandler(this.atividade5ToolStripMenuItem_Click);
            // 
            // atividade6ToolStripMenuItem
            // 
            this.atividade6ToolStripMenuItem.Name = "atividade6ToolStripMenuItem";
            this.atividade6ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.atividade6ToolStripMenuItem.Text = "Atividade 6";
            this.atividade6ToolStripMenuItem.Click += new System.EventHandler(this.atividade6ToolStripMenuItem_Click);
            // 
            // atividade7ToolStripMenuItem
            // 
            this.atividade7ToolStripMenuItem.Name = "atividade7ToolStripMenuItem";
            this.atividade7ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.atividade7ToolStripMenuItem.Text = "Atividade 7";
            this.atividade7ToolStripMenuItem.Click += new System.EventHandler(this.atividade7ToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividade1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade7ToolStripMenuItem;
    }
}

