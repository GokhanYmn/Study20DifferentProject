using Project4_EntityFrameworkCodeFirstMovie.DAL.Context;
using Project4_EntityFrameworkCodeFirstMovie.DAL.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EntityFrameworkCodeFirstMovie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MovieContext context=new MovieContext();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values=context.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtCategoryName.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            int id=Convert.ToInt32(txtCategoryId.Text);
            var values = context.Categories.Find(id);
            values.CategoryName=txtCategoryName.Text;
            context.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(txtCategoryId.Text);
            var values = context.Categories.Find(id);
            context.Categories.Remove(values);
            context.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values= context.Categories.Where(x=>x.CategoryName==txtCategoryName.Text).ToList();
            dataGridView1.DataSource=values;
        }
    }
}
