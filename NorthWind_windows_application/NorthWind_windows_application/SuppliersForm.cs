using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind_windows_application
{
    public partial class SuppliersForm : Form
    {
        DataModel dm = new DataModel();
        int rowindex = -1;

        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            var suppliers = dm.GetSupplierList();

            cb_city.DisplayMember = "City";
            cb_city.ValueMember = "City";
            cb_city.DataSource = suppliers.Select(s => new { s.City }).Distinct().ToList();

            cb_country.DisplayMember = "Country";
            cb_country.ValueMember = "Country";
            cb_country.DataSource = suppliers.Select(s => new { s.Country }).Distinct().ToList();

            cb_postalcode.DisplayMember = "PostalCode";
            cb_postalcode.ValueMember = "PostalCode";
            cb_postalcode.DataSource = suppliers.Select(s => new { s.PostalCode }).Distinct().ToList();

            dataGridView1.DataSource = suppliers;
        }

        private void btn_tedarikcikaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_companyname.Text) ||
                string.IsNullOrEmpty(tb_contactname.Text) ||
                string.IsNullOrEmpty(tb_contacttitle.Text) ||
                string.IsNullOrEmpty(tb_adress.Text) ||
                cb_city.SelectedValue == null ||
                string.IsNullOrEmpty(cb_postalcode.Text) ||
                cb_country.SelectedValue == null ||
                string.IsNullOrEmpty(mtb_phone.Text) ||
                string.IsNullOrEmpty(tb_fax.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Suppliers supplier = new Suppliers
            {
                CompanyName = tb_companyname.Text,
                ContactName = tb_contactname.Text,
                ContactTitle = tb_contacttitle.Text,
                Address = tb_adress.Text,
                City = cb_city.SelectedValue.ToString(),
                PostalCode = cb_postalcode.Text,
                Country = cb_country.SelectedValue.ToString(),
                Phone = mtb_phone.Text,
                Fax = tb_fax.Text
            };

            if (dm.AddSupplier(supplier))
            {
                MessageBox.Show("Tedarikçi eklendi", "Başarılı");
                dataGridView1.DataSource = dm.GetSupplierList();
                btn_formutemizle_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Tedarikçi eklerken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_formutemizle_Click(object sender, EventArgs e)
        {
            tb_companyname.Clear();
            tb_contactname.Clear();
            tb_contacttitle.Clear();
            tb_adress.Clear();
            mtb_phone.Clear();
            tb_fax.Clear();

            cb_city.SelectedIndex = -1;
            cb_postalcode.SelectedIndex = -1;
            cb_country.SelectedIndex = -1;

            rowindex = -1;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (rowindex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowindex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                }
            }
        }

        private void TSMI_duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["SupplierID"].Value);
                Suppliers supplier = dm.GetSupplier(id);
                if (supplier != null)
                {
                    tb_companyname.Text = supplier.CompanyName;
                    tb_contactname.Text = supplier.ContactName;
                    tb_contacttitle.Text = supplier.ContactTitle;
                    tb_adress.Text = supplier.Address;
                    cb_city.SelectedValue = supplier.City;
                    cb_postalcode.Text = supplier.PostalCode;
                    cb_country.SelectedValue = supplier.Country;
                    mtb_phone.Text = supplier.Phone;
                    tb_fax.Text = supplier.Fax;

                    btn_duzenle.Visible = true;
                }
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["SupplierID"].Value);
                string name = dataGridView1.Rows[rowindex].Cells["CompanyName"].Value.ToString();
                if (MessageBox.Show(name + " tedarikçisini silmek istiyor musunuz?", "Tedarikçi Siliniyor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dm.DeleteSupplier(id);
                    MessageBox.Show(name + " silindi", "Tedarikçi silindi");
                }
                dataGridView1.DataSource = dm.GetSupplierList();
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int supplierId = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["SupplierID"].Value);

                Suppliers updatedSupplier = new Suppliers
                {
                    SupplierID = supplierId,
                    CompanyName = string.IsNullOrEmpty(tb_companyname.Text) ? null : tb_companyname.Text,
                    ContactName = string.IsNullOrEmpty(tb_contactname.Text) ? null : tb_contactname.Text,
                    ContactTitle = string.IsNullOrEmpty(tb_contacttitle.Text) ? null : tb_contacttitle.Text,
                    Address = string.IsNullOrEmpty(tb_adress.Text) ? null : tb_adress.Text,
                    City = cb_city.SelectedValue != null ? cb_city.SelectedValue.ToString() : null,
                    PostalCode = string.IsNullOrEmpty(cb_postalcode.Text) ? null : cb_postalcode.Text,
                    Country = cb_country.SelectedValue != null ? cb_country.SelectedValue.ToString() : null,
                    Phone = string.IsNullOrEmpty(mtb_phone.Text) ? null : mtb_phone.Text,
                    Fax = string.IsNullOrEmpty(tb_fax.Text) ? null : tb_fax.Text
                };

                try
                {
                    if (dm.UpdateSupplier(updatedSupplier))
                    {
                        MessageBox.Show("Tedarikçi düzenlendi", "Başarılı");
                        dataGridView1.DataSource = dm.GetSupplierList();
                    }
                    else
                    {
                        MessageBox.Show("Tedarikçi düzenlenirken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz tedarikçiyi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
