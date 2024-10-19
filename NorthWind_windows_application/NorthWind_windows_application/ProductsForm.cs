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
    public partial class ProductsForm : Form
    {
        DataModel dm = new DataModel();
        int rowindex = -1;

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            cb_category.ValueMember = "CategoryID";
            cb_category.DisplayMember = "CategoryName";
            cb_category.DataSource = dm.GetCategoryList();

            cb_supplier.ValueMember = "SupplierID";
            cb_supplier.DisplayMember = "CompanyName";
            cb_supplier.DataSource = dm.GetSupplierList();

            dataGridView1.DataSource = dm.GetProductList();
        }

        private void btn_urunkaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_productname.Text))
            {
                Product p = new Product
                {
                    ProductName = tb_productname.Text,
                    CategoryID = (int)cb_category.SelectedValue,
                    SupplierID = (int)cb_supplier.SelectedValue,
                    QuantityPerUnit = tb_paketleme.Text,
                    UnitPrice = decimal.Parse(nud_fiyat.Text),
                    UnitsInStock = short.Parse(nud_stok.Text),
                    UnitsOnOrder = short.Parse(nud_siparisstok.Text),
                    ReorderLevel = short.Parse(nud_guvenlikstogu.Text),
                    Discontinued = chb_satisdurum.Checked
                };

                if (dm.AddProduct(p))
                {
                    MessageBox.Show("Ürün eklendi", "Başarılı");
                    dataGridView1.DataSource = dm.GetProductList();
                }
                else
                {
                    MessageBox.Show("Ürün eklerken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ürün Adı boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_formutemizle_Click(object sender, EventArgs e)
        {
            tb_productname.Clear();
            tb_paketleme.Clear();

            nud_guvenlikstogu.Value = 0;
            nud_fiyat.Value = 0;
            nud_stok.Value = 0;
            nud_siparisstok.Value = 0;

            cb_category.SelectedIndex = -1;
            cb_supplier.SelectedIndex = -1;

            chb_satisdurum.Checked = false;
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
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["ProductID"].Value);
                Product p = dm.GetProduct(id);
                if (p != null)
                {
                    tb_productname.Text = p.ProductName;
                    cb_category.SelectedValue = p.CategoryID;
                    cb_supplier.SelectedValue = p.SupplierID;
                    tb_paketleme.Text = p.QuantityPerUnit;
                    nud_fiyat.Value = p.UnitPrice;
                    nud_stok.Value = p.UnitsInStock;
                    nud_siparisstok.Value = p.UnitsOnOrder;
                    nud_guvenlikstogu.Value = p.ReorderLevel;
                    chb_satisdurum.Checked = p.Discontinued;

                    btn_duzenle.Visible = true; 
                }
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["ProductID"].Value);
                string name = dataGridView1.Rows[rowindex].Cells["ProductName"].Value.ToString();
                if (MessageBox.Show(name + " ürününü silmek istiyor musunuz?", "Ürün Siliniyor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dm.DeleteProduct(id);
                    MessageBox.Show(name + "silindi", "Ürün silindi");
                }
                dataGridView1.DataSource = dm.GetProductList();
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1) 
            {
                if (!string.IsNullOrEmpty(tb_productname.Text))
                {
                    int productId = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["ProductID"].Value);

                    Product p = new Product()
                    {
                        ProductID = productId,
                        ProductName = tb_productname.Text,
                        CategoryID = (int)cb_category.SelectedValue,
                        SupplierID = (int)cb_supplier.SelectedValue,
                        QuantityPerUnit = tb_paketleme.Text,
                        UnitPrice = nud_fiyat.Value,
                        UnitsInStock = (short)nud_stok.Value,
                        UnitsOnOrder = (short)nud_siparisstok.Value,
                        ReorderLevel = (short)nud_guvenlikstogu.Value,
                        Discontinued = chb_satisdurum.Checked
                    };

                    if (dm.UpdateProduct(p))
                    {
                        MessageBox.Show("Ürün düzenlendi", "Başarılı");
                        dataGridView1.DataSource = dm.GetProductList();
                    }
                    else
                    {
                        MessageBox.Show("Ürün düzenlenirken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ürün Adı boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz ürünü seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
