namespace NorthWind_windows_application
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CategoryForm = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Urunislem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_calisanislemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_musteriislemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.TSMI_CategoryForm,
            this.TSMI_Urunislem,
            this.TSMI_suppliers,
            this.TSMI_calisanislemleri,
            this.TSMI_musteriislemleri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // TSMI_CategoryForm
            // 
            this.TSMI_CategoryForm.Name = "TSMI_CategoryForm";
            this.TSMI_CategoryForm.Size = new System.Drawing.Size(140, 24);
            this.TSMI_CategoryForm.Text = "Kategori İşlemleri";
            this.TSMI_CategoryForm.Click += new System.EventHandler(this.TSMI_CategoryForm_Click);
            // 
            // TSMI_Urunislem
            // 
            this.TSMI_Urunislem.Name = "TSMI_Urunislem";
            this.TSMI_Urunislem.Size = new System.Drawing.Size(114, 24);
            this.TSMI_Urunislem.Text = "Ürün İşlemleri";
            this.TSMI_Urunislem.Click += new System.EventHandler(this.TSMI_Urunislem_Click);
            // 
            // TSMI_suppliers
            // 
            this.TSMI_suppliers.Name = "TSMI_suppliers";
            this.TSMI_suppliers.Size = new System.Drawing.Size(142, 24);
            this.TSMI_suppliers.Text = "Tedarikçi İşlemleri";
            this.TSMI_suppliers.Click += new System.EventHandler(this.TSMI_suppliers_Click);
            // 
            // TSMI_calisanislemleri
            // 
            this.TSMI_calisanislemleri.Name = "TSMI_calisanislemleri";
            this.TSMI_calisanislemleri.Size = new System.Drawing.Size(130, 24);
            this.TSMI_calisanislemleri.Text = "Çalışan İşlemleri";
            this.TSMI_calisanislemleri.Click += new System.EventHandler(this.TSMI_calisanislemleri_Click);
            // 
            // TSMI_musteriislemleri
            // 
            this.TSMI_musteriislemleri.Name = "TSMI_musteriislemleri";
            this.TSMI_musteriislemleri.Size = new System.Drawing.Size(132, 24);
            this.TSMI_musteriislemleri.Text = "Müşteri İşlemleri";
            this.TSMI_musteriislemleri.Click += new System.EventHandler(this.TSMI_musteriislemleri_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind Business";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CategoryForm;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Urunislem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_suppliers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_calisanislemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_musteriislemleri;
    }
}