using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project10_PostgreSQLToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ToDoList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From ToDoLists";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        void CategoryList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Categories";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource=dt;
            connection.Close();
        }

        string connectionString = "Server=localHost;port=5432;Database=DbProject10TodoApp;user ID=postgres;Password=Delgado10";
        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ToDoList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToDoList();
            CategoryList();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select todolistid,title,description,status,priority,categoryname From ToDoLists inner Join categories on todolists.categoryid=categories.categoryid";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(cmbCategory.SelectedValue.ToString());
            string title=txtTitle.Text;
            string description=txtDescription.Text;
            string priority=txtPriorty.Text;
            //string status="B'0'";

            //if (rdbFinish.Checked)
            //{
            //    status="B'1'";
            //}
            //if (rdbContinue.Checked)
            //{
            //    status = "B'0'";
            //}


            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into TodoLists (title,description,status,priority,categoryid) values (@title,@description,@status,@priority,@categoryid)";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@priority", priority);
             //   command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@categoryid", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Yapılacak İş Eklendi");
                ToDoList();
            }
            connection.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query2 = "Delete from TodoLists Where todolistid=@todolistid";
            using (var command = new NpgsqlCommand(query2, connection))
            {
                command.Parameters.AddWithValue("@todolistid", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Veri Başarıyla Silindi");
                ToDoList();
            }
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            string priority = txtPriorty.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update ToDoLists Set Title=@title,Description=@description,Priority=@priority,categoryId=@categoryId Where todolistid=@todolistid ";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@todolistid", id);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@priority", priority);
               // command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@categoryid", id);
                
                command.ExecuteNonQuery();
                MessageBox.Show("Yapılacak Görev Güncellendi");
                ToDoList();
            }
            connection.Close();
        }

        private void btnFinishList_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From ToDoLists where Status='1'";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void btnContinueList_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From ToDoLists where Status='0'";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
