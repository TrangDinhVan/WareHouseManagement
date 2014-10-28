using System;
using System.Collections.Generic;
using System.Text;
//OleDB library
using System.Data.OleDb;
using System.Data;
using WarehouseEntity;

namespace WarehouseDatabaseHelper
{
    public class OrderDAL
    {
        public DataTable getAllOrder()
        {
            string queryAll = "select * from [order]";
            return new Connection().getListRecord(queryAll);
        }
        public DataTable getSomeOrder(string query)
        {
            return new Connection().getListRecord(query);
        }
        public Order getOneOrder(int ID)
        {
            string queryOne = string.Format("select * from [order] where order_id = {0}", ID);
            DataRow r = new Connection().getOneRecord(queryOne);
            Customer cus = new CustomerDAL().GetOneCustomer(int.Parse(r["customer_id"].ToString()));
            DataTable lstOrderDetail = new OrderDetailDAL().getSomeOrderDetail(string.Format("select * from [order_detail] where order_id = {0}",ID));
            Order order = new Order();
            order.Id = ID;
            order.Date = Convert.ToDateTime(r["start_date"].ToString());
            order.Paid = Convert.ToDouble(r["order_paid"].ToString());
            order.Customer = cus;
            order.LstOrderDetail = lstOrderDetail;
            return order;
        }
        public int deleteOrder(int ID)
        {
            string queryDelete = string.Format("delete from [order] where order_id = {0}",ID);
            return new Connection().exeNonQuery(queryDelete);
        } 
        public int createOrder(Order order)
        {
            string queryAdd = string.Format("insert into [order] (order_date, customer_id, order_paid) values ('{0}',{1}),'{2}'",order.Date,order.Customer.Id,order.Paid);
            return new Connection().exeNonQuery(queryAdd);
        }
        public int updateOrder(Order order)
        {
            string queryUpdate = string.Format("update [order] set order_date = {0}, customer_id = {1}, order_paid = {2} where order_id = {3}", order.Date, order.Customer.Id, order.Paid, order.Id);
            return new Connection().exeNonQuery(queryUpdate);
        }
    }
}
