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
        public DataTable getAllOrderDetail()
        {
            string queryAll = "select * from [order_detail]";
            return new Connection().GetListRecord(queryAll);
        }
        public DataTable getSomeOrderDetail(string query)
        {
            return new Connection().GetListRecord(query);
        }
        public OrderDetail getOneOrderDetail(int ID)
        {
            string queryOne = string.Format("select * from [order_detail] where order_detail_id = {0}", ID);
            DataRow r = new Connection().GetOneRecord(queryOne);
            OrderDetail detail = new OrderDetail();
            detail.Id = ID;
            detail.Order = new OrderDAL().getOneOrder(int.Parse(r["order_id"].ToString()));
            detail.Repo = new RepositoryDAL().GetOneRepo(int.Parse(r["repo_id"].ToString()));
            detail.StartDate = Convert.ToDateTime(r["start_date"].ToString());
            detail.EndDate = Convert.ToDateTime(r["end_date"].ToString());
            return detail;
        }
        public int deleteOrderDetail(int ID){
            string queryDelete = string.Format("delete from [order_detail] where order_detail_id = {0}", ID);
            return new Connection().ExeNonQuery(queryDelete);
        }
        public int createOrderDetail(OrderDetail detail)
        {
            string queryAdd = string.Format("insert into order_detail (order_id, repo_id, start_date, end_date)",detail.Order.Id, detail.Repo.Id,detail.StartDate,detail.EndDate);
            return new Connection().ExeNonQuery(queryAdd);
        }
        public int updateOrderDetail(OrderDetail detail)
        {
            string queryUpdate = string.Format("update [order_detail] set order_id = {0}, repo_id = {1}, start_date = {2}, end_date = {3} where order_detail_id = {4}",detail.Order.Id, detail.Repo.Id, detail.StartDate, detail.EndDate, detail.Id);
            return new Connection().ExeNonQuery(queryUpdate);
        }
    }
}
