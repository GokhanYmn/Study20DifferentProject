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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        DbProductEntities db=new DbProductEntities();
        void Temizle(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                // Eğer kontrol bir TextBox ise, içeriğini temizle
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
        }
        void CategoryList()
        {
            
            dataGridView1.DataSource =db.TblCategory.ToList();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblCategory tblCategory = new TblCategory();
            tblCategory.CategoryName=txtCategoryName.Text;
            db.TblCategory.Add(tblCategory);
            db.SaveChanges();
            CategoryList();
            Temizle(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtId.Text);
            var values = db.TblCategory.Find(id);
            db.TblCategory.Remove(values);
            db.SaveChanges();
            CategoryList();
            Temizle(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var values = db.TblCategory.Find(id);
            values.CategoryName = txtCategoryName.Text;
            db.SaveChanges();
            CategoryList();
            Temizle(this);

        }
    }
}
