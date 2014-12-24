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
        public DataTable GetAllOrder()
        {
            string queryAll = "select * from [v_order]";
            return new Connection().GetListRecord(queryAll);
        }
        public DataTable GetSomeOrder(string query)
        {
            return new Connection().GetListRecord(query);
        }
        public Order GetOneOrder(int ID)
        {
            string queryOne = string.Format("select * from [order] where order_id = {0}", ID);
            DataRow r = new Connection().GetOneRecord(queryOne);
            Customer cus = new CustomerDAL().GetOneCustomer(int.Parse(r["customer_id"].ToString()));
            Staff staff = new StaffDAL().GetOneStaff(int.Parse(r["staff_id"].ToString()));
            DataTable lstOrderDetail = new OrderDetailDAL().GetSomeOrderDetail(string.Format("select * from [order_detail] where order_id = {0}",ID));
            Order order = new Order
            {
                Id = ID,
                Date = Convert.ToDateTime(r["order_date"].ToString()),
                Paid = Convert.ToDouble(r["order_paid"].ToString()),
                Customer = cus,
                Staff = staff,
                LstOrderDetail = lstOrderDetail
            };
            return order;
        }
        public int DeleteOrder(int ID)
        {
            string queryDelete = string.Format("delete from [order] where order_id = {0}",ID);
            return new Connection().ExeNonQuery(queryDelete);
        } 
        public int CreateOrder(Order order)
        {
            string queryAdd = string.Format("insert into [order] (order_date, customer_id, order_paid, staff_id) values ('{0}', {1}, {2},{3})", order.Date.ToShortDateString(), order.Customer.Id, order.Paid,order.Staff.Id);
            return new Connection().ExeNonQuery(queryAdd);

        }
        public int UpdateOrder(Order order)
        {
            string queryUpdate = string.Format("update [order] set order_paid = {0} where order_id = {1}", order.Paid, order.Id);
            return new Connection().ExeNonQuery(queryUpdate);
        }
        public int GetScopeIdentity()
        {
            string queryScopeIdentiy = string.Format("select max([order_id]) from [order]");
            DataRow r = new Connection().GetOneRecord(queryScopeIdentiy);
            return Convert.ToInt32(r[0].ToString());
        }
    }
}
