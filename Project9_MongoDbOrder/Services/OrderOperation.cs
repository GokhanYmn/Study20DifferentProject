using MongoDB.Bson;
using MongoDB.Driver;
using Project9_MongoDbOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_MongoDbOrder.Services
{
    public class OrderOperation
    {
        public void AddOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollection();

            var document = new BsonDocument
            {

                {"CustomerName",order.CustomerName},
                {"City",order.City},
                {"District",order.District},
                {"TotalPrice",order.TotalPrice}

            };

            orderCollection.InsertOne(document);
        }

        public List<Order> GetAllOrders()
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollection();

            var orders = orderCollection.Find(new BsonDocument()).ToList();

            List<Order> orderList = new List<Order>();

            foreach (var order in orders)
            {
                orderList.Add(new Order
                {
                    City = order["City"].ToString(),
                    CustomerName = order["CustomerName"].ToString(),
                    District = order["District"].ToString(),
                    OrderId = order["_id"].ToString(),
                    TotalPrice =decimal.Parse(order["TotalPrice"].ToString())

                });
            }
            return orderList;

        }

        public void DeleteOrder(string orderId) 
        {
            var connnection=new MongoDbConnection();
            var orderCollection=connnection.GetOrdersCollection();
            var filter=Builders<BsonDocument>.Filter.Eq("_id",ObjectId.Parse(orderId));
            orderCollection.DeleteOne(filter);
        }

        public void UpdateOrder(Order order)
        {
            var connnection=new MongoDbConnection();
            var orderCollection= connnection.GetOrdersCollection();
            var filter=Builders<BsonDocument>.Filter.Eq("_id",ObjectId.Parse(order.OrderId));
            var updatedValue = Builders<BsonDocument>.Update
                .Set("CustomerName", order.CustomerName)
                .Set("District", order.District)
                .Set("City", order.City)
                .Set("TotalPrice", order.TotalPrice);
            orderCollection.UpdateOne(filter,updatedValue);
        }

        public Order GetByOrderById(string orderId)
        {
            var connnection=new MongoDbConnection();
            var orderConnection=connnection.GetOrdersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            var result = orderConnection.Find(filter).FirstOrDefault();
            if (result == null)
            {
                return new Order
                {
                    City = result["City"].ToString(),
                    CustomerName = result["CustomerName"].ToString(),
                    District = result["District"].ToString(),
                    OrderId=orderId,
                    TotalPrice = decimal.Parse(result["TotalPrice"].ToString())

                };
            }
            else
            {
                return null;
            }
        }
    }
}
