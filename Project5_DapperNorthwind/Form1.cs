using Dapper;
using Project5_DapperNorthwind.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5_DapperNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-3HV2966;initial catalog=Db&ProjectDapper;integrated security=true");
        private async void Form1_Load(object sender, EventArgs e)
        {
            // Kategori sayısı
            string query = "Select Count(*) From Categories";
            var count=await sqlConnection.ExecuteScalarAsync<int>(query);
            lblCategoryCount.Text ="Toplam Kategori Sayısı :" + count;

            //Ürün Sayısı
            string query2 = "Select Count(*) From Products";
            var count2=await sqlConnection.ExecuteScalarAsync<int>(query2);
            lblProductCount.Text="Toplam Ürün Sayısı :" + count2;

            //Ortalama Ürün Stoğu
            string query3 = "Select Avg(UnitsInStock) From Products";
            var count3=await sqlConnection.ExecuteScalarAsync<int>(query3);
            lblAvarageProductStock.Text="Ortalama Ürün Stoğu :" + count3;

            //Deniz Ürünleri Toplam Fiyatı
            string query4 = "Select Sum(UnitPrice) From Products Where CategoryId=(Select CategoryId From Categories Where CategoryName='SeaFood')";
            var count4=await sqlConnection.ExecuteScalarAsync<decimal>(query4);
            lblSeaFoodTotalPrice.Text="Deniz Ürünleri Sayısı :" + count4;
        }

        private async void btnCategoryList_Click(object sender, EventArgs e)
        {
            string query = "Select * From Categories";
            var values=await sqlConnection.QueryAsync<ResultCategoryDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Categories (CategoryName,Description) Values(@p1,@p2)";
            var parameters = new DynamicParameters();
            parameters.Add("@p1", txtCategoryName.Text);
            parameters.Add("@p2",txtDescription.Text);
            await sqlConnection.ExecuteAsync(sql, parameters);
        }

        private async void btnCategoryRemove_Click(object sender, EventArgs e)
        {
            string query = "Delete from Categories where CategoryId=@categoryId)";
            var parameters = new DynamicParameters();
            parameters.Add("@p1",txtCategoryId.Text);
            await sqlConnection.ExecuteAsync(query, parameters);
        }

        private async void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Categories set CategoryName=@categoryName, Description=@description where CategoryId=@categoryId ";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", txtCategoryName);
            parameters.Add("@description", txtDescription);
            parameters.Add("=@categoryId", txtCategoryId);
            await sqlConnection.ExecuteAsync(query, parameters);
        }
    }
}
