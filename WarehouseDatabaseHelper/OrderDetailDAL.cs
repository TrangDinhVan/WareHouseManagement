using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;
using WarehouseEntity;

namespace WarehouseDatabaseHelper
{
    public class OrderDetailDAL
    {
        public DataTable GetAllOrderDetail()
        {
            string queryAll = "select * from [order_detail]";
            return new Connection().GetListRecord(queryAll);
        }
        public DataTable GetSomeOrderDetail(string query)
        {
            return new Connection().GetListRecord(query);
        }
        public OrderDetail GetOneOrderDetail(int ID)
        {
            string queryOne = string.Format("select * from [order_detail] where order_detail_id = {0}", ID);
            DataRow r = new Connection().GetOneRecord(queryOne);
            OrderDetail detail = new OrderDetail
            {
                Id = ID,
                Order = new OrderDAL().GetOneOrder(int.Parse(r["order_id"].ToString())),
                Repo = new RepositoryDAL().GetOneRepo(int.Parse(r["repo_id"].ToString())),
                StartDate = Convert.ToDateTime(r["start_date"].ToString()),
                EndDate = Convert.ToDateTime(r["end_date"].ToString()),
                CheckedOut = Convert.ToBoolean(r["checked_out"].ToString())
            };
            return detail;
        }
        public int DeleteOrderDetail(int ID){
            string queryDelete = string.Format("delete from [order_detail] where order_detail_id = {0}", ID);
            return new Connection().ExeNonQuery(queryDelete);
        }
        public int CreateOrderDetail(OrderDetail detail)
        {
            string queryAdd = string.Format("insert into [order_detail] (order_id, repo_id, start_date, end_date) values ({0},{1},'{2}','{3}')",detail.Order.Id, detail.Repo.Id,detail.StartDate.ToShortDateString(),detail.EndDate.ToShortDateString());
            return new Connection().ExeNonQuery(queryAdd);
        }
        public int UpdateOrderDetail(OrderDetail detail)
        {
            string queryUpdate = string.Format("update [order_detail] set order_id = {0}, repo_id = {1}, start_date = {2}, end_date = {3} where order_detail_id = {4}",detail.Order.Id, detail.Repo.Id, detail.StartDate.ToShortDateString(), detail.EndDate.ToShortDateString(), detail.Id);
            return new Connection().ExeNonQuery(queryUpdate);
        }
    }
}
