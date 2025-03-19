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
using System.Windows.Forms.DataVisualization.Charting;

namespace Project18_DashboardSuperStoreDataset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-3HV2966;initial catalog=Db17KaggleDataSet;integrated security=true");
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Widgets

            #endregion

            #region Chart
            sqlConnection.Open();
            SqlCommand command5 = new SqlCommand("SELECT TOP 7 Country, COUNT(*) AS OrderCount FROM superstore GROUP BY Country ORDER BY COUNT(*) DESC;", sqlConnection);
            SqlDataReader reader5 = command5.ExecuteReader();
            while (reader5.Read())
            {
                chart1.Series["Series1"].Points.AddXY(reader5[0],reader5[1]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command6 = new SqlCommand("SELECT TOP 5 country, SUM(quantity) FROM superstore GROUP BY Country ORDER BY SUM(quantity) DESC;", sqlConnection);
            SqlDataReader reader6 = command6.ExecuteReader();
            while (reader6.Read())
            {
                chart2.Series["Series1"].Points.AddXY(reader6[0], reader6[1]);
            }
            sqlConnection.Close();


            sqlConnection.Open();
            SqlCommand command7 = new SqlCommand("SELECT Order_Priority, COUNT(*) FROM superstore GROUP BY Order_Priority ORDER BY Order_Priority DESC;", sqlConnection);
            SqlDataReader reader7 = command7.ExecuteReader();
            while (reader7.Read())
            {
                chart3.Series["Series1"].Points.AddXY(reader7[0], reader7[1]);
            }
            sqlConnection.Close();

           

            #endregion

            sqlConnection.Open();
            SqlCommand command=new SqlCommand("Select count(*) from superstore",sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblProductCount.Text = reader[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command2 = new SqlCommand("Select count(Distinct(State)) from superstore", sqlConnection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                lblCityCount.Text = reader2[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command3 = new SqlCommand("Select Sum(Quantity) from superstore", sqlConnection);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                lblTotalOrderCount.Text = reader3[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command4 = new SqlCommand("Select count(*) from superstore where Country='Turkey'", sqlConnection);
            SqlDataReader reader4 = command4.ExecuteReader();
            while (reader4.Read())
            {
                lblOrderFromTurkiye.Text = reader4[0].ToString();
            }
            sqlConnection.Close();
        }

      
    }
}
