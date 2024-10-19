namespace NorthWind_windows_application
{
    partial class ProductsForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_formutemizle = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_urunkaydet = new System.Windows.Forms.Button();
            this.chb_satisdurum = new System.Windows.Forms.CheckBox();
            this.tb_paketleme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.nud_siparisstok = new System.Windows.Forms.NumericUpDown();
            this.nud_guvenlikstogu = new System.Windows.Forms.NumericUpDown();
            this.nud_fiyat = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_productname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_supplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_siparisstok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_guvenlikstogu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_formutemizle);
            this.groupBox1.Controls.Add(this.btn_duzenle);
            this.groupBox1.Controls.Add(this.btn_urunkaydet);
            this.groupBox1.Controls.Add(this.chb_satisdurum);
            this.groupBox1.Controls.Add(this.tb_paketleme);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nud_stok);
            this.groupBox1.Controls.Add(this.nud_siparisstok);
            this.groupBox1.Controls.Add(this.nud_guvenlikstogu);
            this.groupBox1.Controls.Add(this.nud_fiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_productname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_supplier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_category);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // btn_formutemizle
            // 
            this.btn_formutemizle.Location = new System.Drawing.Point(678, 151);
            this.btn_formutemizle.Name = "btn_formutemizle";
            this.btn_formutemizle.Size = new System.Drawing.Size(180, 24);
            this.btn_formutemizle.TabIndex = 9;
            this.btn_formutemizle.Text = "Formu Temizle";
            this.btn_formutemizle.UseVisualStyleBackColor = true;
            this.btn_formutemizle.Click += new System.EventHandler(this.btn_formutemizle_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(678, 121);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(180, 24);
            this.btn_duzenle.TabIndex = 8;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Visible = false;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_urunkaydet
            // 
            this.btn_urunkaydet.Location = new System.Drawing.Point(678, 121);
            this.btn_urunkaydet.Name = "btn_urunkaydet";
            this.btn_urunkaydet.Size = new System.Drawing.Size(180, 24);
            this.btn_urunkaydet.TabIndex = 8;
            this.btn_urunkaydet.Text = "Ürün Kaydet";
            this.btn_urunkaydet.UseVisualStyleBackColor = true;
            this.btn_urunkaydet.Click += new System.EventHandler(this.btn_urunkaydet_Click);
            // 
            // chb_satisdurum
            // 
            this.chb_satisdurum.AutoSize = true;
            this.chb_satisdurum.Location = new System.Drawing.Point(678, 75);
            this.chb_satisdurum.Name = "chb_satisdurum";
            this.chb_satisdurum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chb_satisdurum.Size = new System.Drawing.Size(108, 20);
            this.chb_satisdurum.TabIndex = 7;
            this.chb_satisdurum.Text = "Satış Durumu";
            this.chb_satisdurum.UseVisualStyleBackColor = true;
            // 
            // tb_paketleme
            // 
            this.tb_paketleme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_paketleme.Location = new System.Drawing.Point(467, 33);
            this.tb_paketleme.Name = "tb_paketleme";
            this.tb_paketleme.Size = new System.Drawing.Size(179, 22);
            this.tb_paketleme.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Paketleme:";
            // 
            // nud_stok
            // 
            this.nud_stok.Location = new System.Drawing.Point(468, 150);
            this.nud_stok.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(178, 22);
            this.nud_stok.TabIndex = 4;
            // 
            // nud_siparisstok
            // 
            this.nud_siparisstok.Location = new System.Drawing.Point(468, 111);
            this.nud_siparisstok.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.nud_siparisstok.Name = "nud_siparisstok";
            this.nud_siparisstok.Size = new System.Drawing.Size(178, 22);
            this.nud_siparisstok.TabIndex = 4;
            // 
            // nud_guvenlikstogu
            // 
            this.nud_guvenlikstogu.Location = new System.Drawing.Point(468, 72);
            this.nud_guvenlikstogu.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.nud_guvenlikstogu.Name = "nud_guvenlikstogu";
            this.nud_guvenlikstogu.Size = new System.Drawing.Size(178, 22);
            this.nud_guvenlikstogu.TabIndex = 4;
            // 
            // nud_fiyat
            // 
            this.nud_fiyat.DecimalPlaces = 2;
            this.nud_fiyat.Location = new System.Drawing.Point(745, 35);
            this.nud_fiyat.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_fiyat.Name = "nud_fiyat";
            this.nud_fiyat.Size = new System.Drawing.Size(119, 22);
            this.nud_fiyat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sipariş edilen stok:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Güvenlik Stoğu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(675, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID:";
            // 
            // tb_id
            // 
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(99, 29);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(223, 22);
            this.tb_id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Adı:";
            // 
            // tb_productname
            // 
            this.tb_productname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_productname.Location = new System.Drawing.Point(99, 110);
            this.tb_productname.Name = "tb_productname";
            this.tb_productname.Size = new System.Drawing.Size(223, 22);
            this.tb_productname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tedarikçi:";
            // 
            // cb_supplier
            // 
            this.cb_supplier.FormattingEnabled = true;
            this.cb_supplier.Location = new System.Drawing.Point(99, 149);
            this.cb_supplier.Name = "cb_supplier";
            this.cb_supplier.Size = new System.Drawing.Size(223, 24);
            this.cb_supplier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori:";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(99, 71);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(223, 24);
            this.cb_category.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(888, 188);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_duzenle,
            this.TSMI_sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // TSMI_duzenle
            // 
            this.TSMI_duzenle.Name = "TSMI_duzenle";
            this.TSMI_duzenle.Size = new System.Drawing.Size(132, 24);
            this.TSMI_duzenle.Text = "Düzenle";
            this.TSMI_duzenle.Click += new System.EventHandler(this.TSMI_duzenle_Click);
            // 
            // TSMI_sil
            // 
            this.TSMI_sil.Name = "TSMI_sil";
            this.TSMI_sil.Size = new System.Drawing.Size(132, 24);
            this.TSMI_sil.Text = "Sil";
            this.TSMI_sil.Click += new System.EventHandler(this.TSMI_sil_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductsForm";
            this.Text = "Products Form";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_siparisstok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_guvenlikstogu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_productname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_supplier;
        private System.Windows.Forms.NumericUpDown nud_fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_paketleme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.NumericUpDown nud_siparisstok;
        private System.Windows.Forms.NumericUpDown nud_guvenlikstogu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_formutemizle;
        private System.Windows.Forms.Button btn_urunkaydet;
        private System.Windows.Forms.CheckBox chb_satisdurum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_duzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
        private System.Windows.Forms.Button btn_duzenle;
    }
}