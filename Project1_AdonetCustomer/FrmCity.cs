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

namespace Project1_AdonetCustomer
{
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-3HV2966;initial catalog=DbCustomer;integrated security=true");
        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From TblCity",sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into TblCity (CityName,CityCountry) values(@cityName,@cityCountry)", sqlConnection);
            command.Parameters.AddWithValue("@cityName",txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry",txtCityCountry.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete from TblCity where CityId=@cityId", sqlConnection);
            command.Parameters.AddWithValue("@cityId",txtCityId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir Başarılı Bir Şekilde Silindi","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblCity set CityName=@cityName,CityCountry=@cityCountry where CityId=@cityId)",sqlConnection);
            command.Parameters.AddWithValue("@cityName",txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
            command.Parameters.AddWithValue("@cityId", txtCityId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir Başarılı Bir Şekilde Güncellendi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from TblCity where CityName=@cityName", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@cityName", txtCityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();

        }

        private void FrmCity_Load(object sender, EventArgs e)
        {

        }
    }
}
