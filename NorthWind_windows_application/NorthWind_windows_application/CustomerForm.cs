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
    public partial class CustomerForm : Form
    {
        DataModel dm = new DataModel();
        int rowindex = -1;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            var customers = dm.GetCustomerList();

            dataGridView1.DataSource = customers;

            cb_city.DisplayMember = "City";
            cb_city.ValueMember = "City";
            cb_city.DataSource = customers.Select(c => new { c.City }).Distinct().ToList();

            cb_country.DisplayMember = "Country";
            cb_country.ValueMember = "Country";
            cb_country.DataSource = customers.Select(c => new { c.Country }).Distinct().ToList();

            cb_postalcode.DisplayMember = "PostalCode";
            cb_postalcode.ValueMember = "PostalCode";
            cb_postalcode.DataSource = customers.Select(c => new { c.PostalCode }).Distinct().ToList();
        }

        private string GenerateCustomerID()
        {
            const int idLength = 5;
            string customerID;
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            do
            {
                customerID = new string(Enumerable.Repeat(chars, idLength)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            while (dm.GetCustomer(customerID) != null);

            return customerID;
        }

        private void btn_musterikaydet_Click(object sender, EventArgs e)
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

            Customer customer = new Customer
            {
                CustomerID = GenerateCustomerID(),
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

            if (dm.AddCustomer(customer))
            {
                MessageBox.Show("Müşteri eklendi", "Başarılı");
                dataGridView1.DataSource = dm.GetCustomerList();
                btn_formutemizle_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Müşteri eklerken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_formutemizle_Click(object sender, EventArgs e)
        {
            tb_customerID.Clear();
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
                string customerId = dataGridView1.Rows[rowindex].Cells["CustomerID"].Value.ToString();
                Customer customer = dm.GetCustomer(customerId);
                if (customer != null)
                {
                    tb_customerID.Text = customer.CustomerID;
                    tb_companyname.Text = customer.CompanyName;
                    tb_contactname.Text = customer.ContactName;
                    tb_contacttitle.Text = customer.ContactTitle;
                    tb_adress.Text = customer.Address;
                    cb_city.SelectedValue = customer.City;
                    cb_postalcode.Text = customer.PostalCode;
                    cb_country.SelectedValue = customer.Country;
                    mtb_phone.Text = customer.Phone;
                    tb_fax.Text = customer.Fax;

                    btn_duzenle.Visible = true;
                }
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                string customerId = dataGridView1.Rows[rowindex].Cells["CustomerID"].Value.ToString();
                string name = dataGridView1.Rows[rowindex].Cells["CompanyName"].Value.ToString();
                if (MessageBox.Show(name + " müşterisini silmek istiyor musunuz?", "Müşteri Siliniyor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dm.DeleteCustomer(customerId);
                    MessageBox.Show(name + " silindi", "Müşteri silindi");
                }
                dataGridView1.DataSource = dm.GetCustomerList();
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                string customerId = dataGridView1.Rows[rowindex].Cells["CustomerID"].Value.ToString();

                Customer updatedCustomer = new Customer
                {
                    CustomerID = customerId,
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
                    if (dm.UpdateCustomer(updatedCustomer))
                    {
                        MessageBox.Show("Müşteri düzenlendi", "Başarılı");
                        dataGridView1.DataSource = dm.GetCustomerList();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri düzenlenirken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz müşteriyi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
