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
    public partial class EmployeesForm : Form
    {
        DataModel dm = new DataModel();
        int rowindex = -1;

        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            var employees = dm.GetEmployeeList();

            cb_city.DisplayMember = "City";
            cb_city.ValueMember = "City";
            cb_city.DataSource = employees.Select(s => new { s.City }).Distinct().ToList();

            cb_country.DisplayMember = "Country";
            cb_country.ValueMember = "Country";
            cb_country.DataSource = employees.Select(s => new { s.Country }).Distinct().ToList();

            cb_postalcode.DisplayMember = "PostalCode";
            cb_postalcode.ValueMember = "PostalCode";
            cb_postalcode.DataSource = employees.Select(s => new { s.PostalCode }).Distinct().ToList();

            dataGridView1.DataSource = employees;
        }

        private void btn_personelkaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_firstname.Text) && !string.IsNullOrEmpty(tb_lastname.Text))
            {
                Employees emp = new Employees
                {
                    FirstName = tb_firstname.Text,
                    LastName = tb_lastname.Text,
                    Title = tb_title.Text,
                    TitleOfCourtesy = tb_titlecourtesy.Text,
                    BirthDate = dtp_birthdate.Value,
                    HireDate = dtp_hiredate.Value,
                    Address = tb_address.Text,
                    City = cb_city.SelectedValue.ToString(),
                    PostalCode = cb_postalcode.SelectedValue.ToString(),
                    Country = cb_country.SelectedValue.ToString(),
                    HomePhone = mtb_phone.Text,
                    Extension = tb_extension.Text,
                    Notes = tb_notes.Text,
                    Username = tb_username.Text,
                    Password = tb_password.Text
                };

                if (dm.AddEmployee(emp))
                {
                    MessageBox.Show("Çalışan eklendi", "Başarılı");
                    dataGridView1.DataSource = dm.GetEmployeeList();
                }
                else
                {
                    MessageBox.Show("Çalışan eklenirken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ad ve Soyad boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                if (!string.IsNullOrEmpty(tb_firstname.Text) && !string.IsNullOrEmpty(tb_lastname.Text))
                {
                    int employeeId = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["EmployeeID"].Value);

                    Employees emp = new Employees()
                    {
                        EmployeeID = employeeId,
                        FirstName = tb_firstname.Text,
                        LastName = tb_lastname.Text,
                        Title = tb_title.Text,
                        TitleOfCourtesy = tb_titlecourtesy.Text,
                        BirthDate = dtp_birthdate.Value,
                        HireDate = dtp_hiredate.Value,
                        Address = tb_address.Text,
                        City = cb_city.SelectedValue.ToString(),
                        PostalCode = cb_postalcode.SelectedValue.ToString(),
                        Country = cb_country.SelectedValue.ToString(),
                        HomePhone = mtb_phone.Text,
                        Extension = tb_extension.Text,
                        Notes = tb_notes.Text,
                        Username = tb_username.Text,
                        Password = tb_password.Text
                    };

                    if (dm.UpdateEmployee(emp))
                    {
                        MessageBox.Show("Çalışan güncellendi", "Başarılı");
                        dataGridView1.DataSource = dm.GetEmployeeList();
                    }
                    else
                    {
                        MessageBox.Show("Çalışan güncellenirken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ad ve Soyad boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz çalışanı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_formutemizle_Click(object sender, EventArgs e)
        {
            tb_firstname.Clear();
            tb_lastname.Clear();
            tb_title.Clear();
            tb_titlecourtesy.Clear();
            dtp_birthdate.Value = DateTime.Now;
            dtp_hiredate.Value = DateTime.Now;
            tb_address.Clear();
            cb_postalcode.SelectedIndex = -1;
            mtb_phone.Clear();
            tb_extension.Clear();
            tb_notes.Clear();
            tb_username.Clear();
            tb_password.Clear();
            cb_city.SelectedIndex = -1;
            cb_country.SelectedIndex = -1;
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
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["EmployeeID"].Value);
                Employees emp = dm.GetEmployee(id);
                if (emp != null)
                {
                    tb_firstname.Text = emp.FirstName;
                    tb_lastname.Text = emp.LastName;
                    tb_title.Text = emp.Title;
                    tb_titlecourtesy.Text = emp.TitleOfCourtesy;
                    dtp_birthdate.Value = emp.BirthDate;
                    dtp_hiredate.Value = emp.HireDate;
                    tb_address.Text = emp.Address;
                    cb_city.SelectedValue = emp.City;
                    cb_postalcode.Text = emp.PostalCode;
                    cb_country.SelectedValue = emp.Country;
                    mtb_phone.Text = emp.HomePhone;
                    tb_extension.Text = emp.Extension;
                    tb_notes.Text = emp.Notes;
                    tb_username.Text = emp.Username;
                    tb_password.Text = emp.Password;

                    btn_duzenle.Visible = true;
                }
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["EmployeeID"].Value);
                string name = $"{dataGridView1.Rows[rowindex].Cells["FirstName"].Value} {dataGridView1.Rows[rowindex].Cells["LastName"].Value}";
                if (MessageBox.Show($"{name} adlı çalışanı silmek istiyor musunuz?", "Çalışan Siliniyor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dm.DeleteEmployee(id);
                    MessageBox.Show($"{name} silindi", "Çalışan Silindi");
                }
                dataGridView1.DataSource = dm.GetEmployeeList();
            }
        }

    
    }
}