using Project9_MongoDbOrder.Entities;
using Project9_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OrderOperation operation=new OrderOperation();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City = txtCity.Text,
                CustomerName = txtCustomer.Text,
                District = txtDistrict.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
                
            };

            operation.AddOrder(order);
            MessageBox.Show("Ekleme İşlemi Yapıldı");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Order> orders = operation.GetAllOrders();
            dataGridView1.DataSource = orders;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Order> orders = operation.GetAllOrders();
            dataGridView1.DataSource = orders;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string orderId=txtId.Text;
            operation.DeleteOrder(orderId);
            MessageBox.Show("Silme İşlemi Tamamlandı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string orderId = txtId.Text;
            var updatedOrder = new Order
            {
                City = txtCity.Text,
                CustomerName = txtCustomer.Text,
                District = txtDistrict.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
            };
            operation.UpdateOrder(updatedOrder);

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string orderId = txtId.Text;
            Order orders = operation.GetByOrderById(orderId);
            dataGridView1.DataSource =new List<Order> { orders };
        }
    }
}
