namespace NorthWind_windows_application
{
    partial class EmployeesForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_extension = new System.Windows.Forms.TextBox();
            this.mtb_phone = new System.Windows.Forms.MaskedTextBox();
            this.dtp_hiredate = new System.Windows.Forms.DateTimePicker();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.cb_postalcode = new System.Windows.Forms.ComboBox();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.tb_notes = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_titlecourtesy = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.tb_employeeID = new System.Windows.Forms.TextBox();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_formutemizle = new System.Windows.Forms.Button();
            this.btn_personelkaydet = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tb_extension);
            this.groupBox1.Controls.Add(this.mtb_phone);
            this.groupBox1.Controls.Add(this.dtp_hiredate);
            this.groupBox1.Controls.Add(this.dtp_birthdate);
            this.groupBox1.Controls.Add(this.cb_country);
            this.groupBox1.Controls.Add(this.cb_postalcode);
            this.groupBox1.Controls.Add(this.cb_city);
            this.groupBox1.Controls.Add(this.tb_notes);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Controls.Add(this.tb_titlecourtesy);
            this.groupBox1.Controls.Add(this.tb_title);
            this.groupBox1.Controls.Add(this.tb_lastname);
            this.groupBox1.Controls.Add(this.tb_firstname);
            this.groupBox1.Controls.Add(this.tb_employeeID);
            this.groupBox1.Controls.Add(this.btn_duzenle);
            this.groupBox1.Controls.Add(this.btn_formutemizle);
            this.groupBox1.Controls.Add(this.btn_personelkaydet);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1205, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan İşlemleri";
            // 
            // tb_extension
            // 
            this.tb_extension.Location = new System.Drawing.Point(780, 26);
            this.tb_extension.Name = "tb_extension";
            this.tb_extension.Size = new System.Drawing.Size(130, 22);
            this.tb_extension.TabIndex = 6;
            // 
            // mtb_phone
            // 
            this.mtb_phone.Location = new System.Drawing.Point(551, 170);
            this.mtb_phone.Mask = "(999) 000-0000";
            this.mtb_phone.Name = "mtb_phone";
            this.mtb_phone.Size = new System.Drawing.Size(121, 22);
            this.mtb_phone.TabIndex = 5;
            // 
            // dtp_hiredate
            // 
            this.dtp_hiredate.Location = new System.Drawing.Point(324, 126);
            this.dtp_hiredate.Name = "dtp_hiredate";
            this.dtp_hiredate.Size = new System.Drawing.Size(129, 22);
            this.dtp_hiredate.TabIndex = 4;
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.Location = new System.Drawing.Point(324, 77);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(129, 22);
            this.dtp_birthdate.TabIndex = 4;
            // 
            // cb_country
            // 
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(551, 121);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(121, 24);
            this.cb_country.TabIndex = 3;
            // 
            // cb_postalcode
            // 
            this.cb_postalcode.FormattingEnabled = true;
            this.cb_postalcode.Location = new System.Drawing.Point(551, 75);
            this.cb_postalcode.Name = "cb_postalcode";
            this.cb_postalcode.Size = new System.Drawing.Size(121, 24);
            this.cb_postalcode.TabIndex = 3;
            // 
            // cb_city
            // 
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Location = new System.Drawing.Point(551, 26);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(121, 24);
            this.cb_city.TabIndex = 3;
            // 
            // tb_notes
            // 
            this.tb_notes.Location = new System.Drawing.Point(780, 168);
            this.tb_notes.Name = "tb_notes";
            this.tb_notes.Size = new System.Drawing.Size(129, 22);
            this.tb_notes.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(779, 116);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(130, 22);
            this.tb_password.TabIndex = 2;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(779, 71);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(130, 22);
            this.tb_username.TabIndex = 2;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(324, 172);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(129, 22);
            this.tb_address.TabIndex = 2;
            // 
            // tb_titlecourtesy
            // 
            this.tb_titlecourtesy.Location = new System.Drawing.Point(324, 31);
            this.tb_titlecourtesy.Name = "tb_titlecourtesy";
            this.tb_titlecourtesy.Size = new System.Drawing.Size(129, 22);
            this.tb_titlecourtesy.TabIndex = 2;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(81, 175);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(100, 22);
            this.tb_title.TabIndex = 2;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(81, 130);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(100, 22);
            this.tb_lastname.TabIndex = 2;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(81, 79);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(100, 22);
            this.tb_firstname.TabIndex = 2;
            // 
            // tb_employeeID
            // 
            this.tb_employeeID.Enabled = false;
            this.tb_employeeID.Location = new System.Drawing.Point(80, 31);
            this.tb_employeeID.Name = "tb_employeeID";
            this.tb_employeeID.Size = new System.Drawing.Size(100, 22);
            this.tb_employeeID.TabIndex = 2;
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(915, 170);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(133, 23);
            this.btn_duzenle.TabIndex = 1;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_formutemizle
            // 
            this.btn_formutemizle.Location = new System.Drawing.Point(1054, 170);
            this.btn_formutemizle.Name = "btn_formutemizle";
            this.btn_formutemizle.Size = new System.Drawing.Size(121, 23);
            this.btn_formutemizle.TabIndex = 1;
            this.btn_formutemizle.Text = "Formu Temizle";
            this.btn_formutemizle.UseVisualStyleBackColor = true;
            this.btn_formutemizle.Click += new System.EventHandler(this.btn_formutemizle_Click);
            // 
            // btn_personelkaydet
            // 
            this.btn_personelkaydet.Location = new System.Drawing.Point(915, 170);
            this.btn_personelkaydet.Name = "btn_personelkaydet";
            this.btn_personelkaydet.Size = new System.Drawing.Size(133, 23);
            this.btn_personelkaydet.TabIndex = 1;
            this.btn_personelkaydet.Text = "Personel Kaydet";
            this.btn_personelkaydet.UseVisualStyleBackColor = true;
            this.btn_personelkaydet.Click += new System.EventHandler(this.btn_personelkaydet_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(737, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Şifre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(507, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ülke:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unvan:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(692, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Kullanıcı Adı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(466, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Posta Kodu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "İşe Alım Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(709, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Dahili No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doğum  Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(728, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Notlar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(489, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Şehir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Saygı Unvanı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
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
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeesForm";
            this.Text = "Employees Form";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_formutemizle;
        private System.Windows.Forms.Button btn_personelkaydet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_notes;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_titlecourtesy;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.TextBox tb_employeeID;
        private System.Windows.Forms.MaskedTextBox mtb_phone;
        private System.Windows.Forms.DateTimePicker dtp_hiredate;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.ComboBox cb_postalcode;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.TextBox tb_extension;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_duzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
    }
}