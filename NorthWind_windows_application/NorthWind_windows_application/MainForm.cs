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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TSMI_CategoryForm_Click(object sender, EventArgs e)
        {

            FormOpen(new CategoriesForm());

        }
        public void FormOpen(Form frm)
        {
            Form[] forms = this.MdiChildren;
            bool isOpen = false;

            foreach (Form item in forms)
            {
                if (item.GetType() == frm.GetType())
                {
                    isOpen = true;
                    item.Activate(); 
                    item.WindowState = FormWindowState.Normal;
                    item.WindowState = FormWindowState.Maximized;
                }
            }
            if (!isOpen)
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }

        }

        private void TSMI_Urunislem_Click(object sender, EventArgs e)
        {
            FormOpen(new ProductsForm());
        }

        private void TSMI_suppliers_Click(object sender, EventArgs e)
        {
            FormOpen(new SuppliersForm());
        }

        private void TSMI_calisanislemleri_Click(object sender, EventArgs e)
        {
            FormOpen(new EmployeesForm());
        }

        private void TSMI_musteriislemleri_Click(object sender, EventArgs e)
        {
            FormOpen(new CustomerForm());
        }
    }
}
