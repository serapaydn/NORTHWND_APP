namespace NorthWind_windows_application
{
    partial class CustomerForm
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
            this.mtb_phone = new System.Windows.Forms.MaskedTextBox();
            this.cb_postalcode = new System.Windows.Forms.ComboBox();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.tb_contacttitle = new System.Windows.Forms.TextBox();
            this.tb_fax = new System.Windows.Forms.TextBox();
            this.tb_adress = new System.Windows.Forms.TextBox();
            this.tb_companyname = new System.Windows.Forms.TextBox();
            this.tb_contactname = new System.Windows.Forms.TextBox();
            this.tb_customerID = new System.Windows.Forms.TextBox();
            this.btn_formutemizle = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_musterikaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mtb_phone);
            this.groupBox1.Controls.Add(this.cb_postalcode);
            this.groupBox1.Controls.Add(this.cb_country);
            this.groupBox1.Controls.Add(this.cb_city);
            this.groupBox1.Controls.Add(this.tb_contacttitle);
            this.groupBox1.Controls.Add(this.tb_fax);
            this.groupBox1.Controls.Add(this.tb_adress);
            this.groupBox1.Controls.Add(this.tb_companyname);
            this.groupBox1.Controls.Add(this.tb_contactname);
            this.groupBox1.Controls.Add(this.tb_customerID);
            this.groupBox1.Controls.Add(this.btn_formutemizle);
            this.groupBox1.Controls.Add(this.btn_duzenle);
            this.groupBox1.Controls.Add(this.btn_musterikaydet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1078, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // mtb_phone
            // 
            this.mtb_phone.Location = new System.Drawing.Point(541, 163);
            this.mtb_phone.Mask = "(999) 000-0000";
            this.mtb_phone.Name = "mtb_phone";
            this.mtb_phone.Size = new System.Drawing.Size(120, 22);
            this.mtb_phone.TabIndex = 30;
            // 
            // cb_postalcode
            // 
            this.cb_postalcode.FormattingEnabled = true;
            this.cb_postalcode.Location = new System.Drawing.Point(541, 38);
            this.cb_postalcode.Name = "cb_postalcode";
            this.cb_postalcode.Size = new System.Drawing.Size(121, 24);
            this.cb_postalcode.TabIndex = 29;
            // 
            // cb_country
            // 
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(541, 108);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(121, 24);
            this.cb_country.TabIndex = 28;
            // 
            // cb_city
            // 
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Location = new System.Drawing.Point(302, 163);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(134, 24);
            this.cb_city.TabIndex = 26;
            // 
            // tb_contacttitle
            // 
            this.tb_contacttitle.Location = new System.Drawing.Point(302, 34);
            this.tb_contacttitle.Name = "tb_contacttitle";
            this.tb_contacttitle.Size = new System.Drawing.Size(134, 22);
            this.tb_contacttitle.TabIndex = 25;
            // 
            // tb_fax
            // 
            this.tb_fax.Location = new System.Drawing.Point(744, 40);
            this.tb_fax.Name = "tb_fax";
            this.tb_fax.Size = new System.Drawing.Size(120, 22);
            this.tb_fax.TabIndex = 24;
            // 
            // tb_adress
            // 
            this.tb_adress.Location = new System.Drawing.Point(302, 95);
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(134, 22);
            this.tb_adress.TabIndex = 23;
            // 
            // tb_companyname
            // 
            this.tb_companyname.Location = new System.Drawing.Point(78, 92);
            this.tb_companyname.Name = "tb_companyname";
            this.tb_companyname.Size = new System.Drawing.Size(125, 22);
            this.tb_companyname.TabIndex = 22;
            // 
            // tb_contactname
            // 
            this.tb_contactname.Location = new System.Drawing.Point(78, 157);
            this.tb_contactname.Name = "tb_contactname";
            this.tb_contactname.Size = new System.Drawing.Size(125, 22);
            this.tb_contactname.TabIndex = 21;
            // 
            // tb_customerID
            // 
            this.tb_customerID.Enabled = false;
            this.tb_customerID.Location = new System.Drawing.Point(78, 34);
            this.tb_customerID.Name = "tb_customerID";
            this.tb_customerID.Size = new System.Drawing.Size(125, 22);
            this.tb_customerID.TabIndex = 20;
            // 
            // btn_formutemizle
            // 
            this.btn_formutemizle.Location = new System.Drawing.Point(920, 148);
            this.btn_formutemizle.Name = "btn_formutemizle";
            this.btn_formutemizle.Size = new System.Drawing.Size(123, 31);
            this.btn_formutemizle.TabIndex = 19;
            this.btn_formutemizle.Text = "Formu Temizle";
            this.btn_formutemizle.UseVisualStyleBackColor = true;
            this.btn_formutemizle.Click += new System.EventHandler(this.btn_formutemizle_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(759, 148);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(140, 31);
            this.btn_duzenle.TabIndex = 18;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Visible = false;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_musterikaydet
            // 
            this.btn_musterikaydet.Location = new System.Drawing.Point(759, 148);
            this.btn_musterikaydet.Name = "btn_musterikaydet";
            this.btn_musterikaydet.Size = new System.Drawing.Size(140, 31);
            this.btn_musterikaydet.TabIndex = 17;
            this.btn_musterikaydet.Text = "Müşteri Kaydet\r\n";
            this.btn_musterikaydet.UseVisualStyleBackColor = true;
            this.btn_musterikaydet.Click += new System.EventHandler(this.btn_musterikaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ülke:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(698, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Faks:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Posta Kodu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Telefon No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Şehir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pozisyon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 48);
            this.label3.TabIndex = 7;
            this.label3.Text = "İletişim \r\nKurulacak\r\n Kişi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Firma Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 208);
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
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerForm";
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mtb_phone;
        private System.Windows.Forms.ComboBox cb_postalcode;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.TextBox tb_contacttitle;
        private System.Windows.Forms.TextBox tb_fax;
        private System.Windows.Forms.TextBox tb_adress;
        private System.Windows.Forms.TextBox tb_companyname;
        private System.Windows.Forms.TextBox tb_contactname;
        private System.Windows.Forms.TextBox tb_customerID;
        private System.Windows.Forms.Button btn_formutemizle;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_musterikaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_duzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
    }
}