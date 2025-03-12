using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EntiryFrameWorkDbFirstProduct
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        DbProductEntities db= new DbProductEntities();

        void ProductList()
        {
            dataGridView1.DataSource=db.TblProduct.ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblProduct tblProduct = new TblProduct();
            tblProduct.ProductName = txtProductName.Text;
            tblProduct.ProductStock=Convert.ToInt32( txtStock.Text);
            tblProduct.ProductPrice=Convert.ToUInt32( txtPrice.Text);
            tblProduct.CategoryId=Convert.ToInt32(cmbCategory.SelectedValue);
            db.TblProduct.Add(tblProduct);
            db.SaveChanges();
            ProductList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value  =db.TblProduct.Find(txtProductId.Text);
            db.TblProduct.Remove(value);
            db.SaveChanges();
            ProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(txtProductId.Text);
            value.ProductName = txtProductName.Text;
            value.ProductPrice=Convert.ToDecimal(txtPrice.Text);
            value.ProductStock=Convert.ToInt32(txtStock.Text);
            value.CategoryId= Convert.ToInt32(cmbCategory.SelectedValue);
            db.SaveChanges();
            ProductList();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values=db.TblCategory.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = values;
        }

        private void btnProductListWithCategory_Click(object sender, EventArgs e)
        {
            var values=db.TblProduct
                .Join(db.TblCategory,
                product=>product.CategoryId,
                category=>category.CategoryId,
                (product,category)=>new
                {
                    ProductId=product.ProductId,
                    CategoryId=category.CategoryId,
                    CategoryName=category.CategoryName,
                    ProductName=product.ProductName,
                    ProductPrice=product.ProductPrice,
                    ProductStock=product.ProductStock,
                })
                .ToList();
            dataGridView1.DataSource = values;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values=db.TblProduct.Where(x=>x.ProductName==txtProductName.Text).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
