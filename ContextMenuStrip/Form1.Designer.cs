namespace ContextMenuStrip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            maviToolStripMenuItem = new ToolStripMenuItem();
            yeşilToolStripMenuItem = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem1 = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            hızlıErişimToolStripMenuItem = new ToolStripMenuItem();
            hesapMakinesiToolStripMenuItem = new ToolStripMenuItem();
            paintToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { maviToolStripMenuItem, yeşilToolStripMenuItem, hakkımızdaToolStripMenuItem, hızlıErişimToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(153, 100);
            // 
            // maviToolStripMenuItem
            // 
            maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            maviToolStripMenuItem.Size = new Size(152, 24);
            maviToolStripMenuItem.Text = "Mavi";
            maviToolStripMenuItem.Click += maviToolStripMenuItem_Click;
            // 
            // yeşilToolStripMenuItem
            // 
            yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            yeşilToolStripMenuItem.Size = new Size(152, 24);
            yeşilToolStripMenuItem.Text = "Yeşil";
            yeşilToolStripMenuItem.Click += yeşilToolStripMenuItem_Click;
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkımızdaToolStripMenuItem1, çıkışToolStripMenuItem });
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(152, 24);
            hakkımızdaToolStripMenuItem.Text = "Ayarlar";
            // 
            // hakkımızdaToolStripMenuItem1
            // 
            hakkımızdaToolStripMenuItem1.Name = "hakkımızdaToolStripMenuItem1";
            hakkımızdaToolStripMenuItem1.Size = new Size(170, 26);
            hakkımızdaToolStripMenuItem1.Text = "Hakkımızda";
            hakkımızdaToolStripMenuItem1.Click += hakkımızdaToolStripMenuItem1_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(170, 26);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // hızlıErişimToolStripMenuItem
            // 
            hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hesapMakinesiToolStripMenuItem, paintToolStripMenuItem });
            hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            hızlıErişimToolStripMenuItem.Size = new Size(152, 24);
            hızlıErişimToolStripMenuItem.Text = "Hızlı Erişim";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            hesapMakinesiToolStripMenuItem.Size = new Size(224, 26);
            hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            hesapMakinesiToolStripMenuItem.Click += hesapMakinesiToolStripMenuItem_Click;
            // 
            // paintToolStripMenuItem
            // 
            paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            paintToolStripMenuItem.Size = new Size(224, 26);
            paintToolStripMenuItem.Text = "Paint";
            paintToolStripMenuItem.Click += paintToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem maviToolStripMenuItem;
        private ToolStripMenuItem yeşilToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem1;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private ToolStripMenuItem paintToolStripMenuItem;
    }
}
