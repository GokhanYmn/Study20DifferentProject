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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-3HV2966;initial catalog=DbCustomer;integrated security=true");
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            
            
            SqlCommand sqlCommand = new SqlCommand("select * from TblCity", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cmbCity.ValueMember = "CityId";
            cmbCity.DisplayMember = "CityName";
            cmbCity.DataSource = dt;
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
           
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select CustomerId,CustomerName,CustormerSurname,CustomerBalance,CustomerStatus,CityName from TblCustomer Inner Join TblCity on TblCity.CityId=TblCustomer.CustomerCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlConnection.Close();
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("execute CustomerListWithCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Insert Into TblCustomer (CustomerName,CustomerSurname,CustomerCity,CustomerBalance,CustomerStatus) values (@customerName,@customerSurname,@customerCity,@customerBalance,@CustomerStatus)",sqlConnection);
            cmd.Parameters.AddWithValue("@customerName",txtCustomerName.Text);
            cmd.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            cmd.Parameters.AddWithValue("@customerBalance", txtBalance.Text);
            cmd.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
            if(rdbAktive.Checked)
            {
                cmd.Parameters.AddWithValue("customerStatus",true);
            }
            if (rdbPasive.Checked)
            {
                cmd.Parameters.AddWithValue("customerStatus", false);
            }
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Başarı ile eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from TblCustomer where CustomerId=@customerId", sqlConnection);
            command.Parameters.AddWithValue("@customerId", txtCostumerId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Başarılı Bir Şekilde Silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblCustomer set CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerCity=@customerCity,CustomerBalance=@customerBalance,CustomerStatus=@customerStatus where CustomerId=@customerId)", sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
            command.Parameters.AddWithValue("@customerBalance", txtBalance.Text);
            command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
            command.Parameters.AddWithValue("@customerId", txtCostumerId.Text);
            
            if (rdbAktive.Checked)
            {
                command.Parameters.AddWithValue("customerStatus", true);
            }
            if (rdbPasive.Checked)
            {
                command.Parameters.AddWithValue("customerStatus", false);
            }
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Başarılı Bir Şekilde Güncellendi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select CustomerId,CustomerName,CustormerSurname,CustomerBalance,CustomerStatus,CityName from TblCustomer Inner Join TblCity on TblCity.CityId=TblCustomer.CustomerCity where CustomerName=@customerName", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@customerName",txtCustomerName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlConnection.Close();
        }
    }
}
