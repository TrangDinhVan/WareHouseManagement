using System;
using System.Collections.Generic;
using System.Text;
//using
using WarehouseEntity;
using System.Data;

namespace WarehouseDatabaseHelper
{
    public class MaintainanceDAL
    {
        public DataTable getAllMaintain()
        {
            string queryAll = "select * from [maintainance]";
            return new Connection().getListRecord(queryAll);
        }
        public DataTable getSomeMaintain(string query)
        {
            return new Connection().getListRecord(query);
        }
        public Maintainance getOneMaintain(int ID)
        {
            string queryOne = string.Format("select * from [maintainance] where maintain_id = {0}", ID);
            DataRow r = new Connection().getOneRecord(queryOne);
            Maintainance maintain = new Maintainance();
            maintain.Id = ID;
            maintain.Desc = r["mainatain_desc"].ToString();
            maintain.Price = double.Parse(r["maintain_price"].ToString());
            maintain.StartDate = Convert.ToDateTime(r["start_date"].ToString());
            maintain.EndDate = Convert.ToDateTime((r["end_date"]).ToString());
            maintain.Repo = new RepositoryDAL().getOneRepo(int.Parse(r["repo_id"].ToString()));
            return maintain;
        }
        public int deleteMaintain(int ID)
        {
            string queryDelete = string.Format("delete from repository where repo_id = {0}", ID);
            return new Connection().exeNonQuery(queryDelete);
        }
        public int createMaintain(Maintainance maintain)
        {
            string queryAdd = string.Format("insert into [maintainance] (repo_id, start_date, end_date, maintain_desc, maintain_price) values ({0}, '{1}', '{2}', '{3}', {4})", maintain.Repo.Id, maintain.StartDate, maintain.EndDate, maintain.Desc, maintain.Price);
            return new Connection().exeNonQuery(queryAdd);
        }

        public int updateMaintain(Maintainance maintain)
        {
            string queryUpdate = string.Format("update [maintainance] set repo_id = {0}, start_date = '{1}', end_date = '{2}', maintain_desc = '{3}', maintain_price = {4} where maintain_id = {5}", maintain.Repo.Id, maintain.StartDate, maintain.EndDate, maintain.Desc, maintain.Price, maintain.Id);
            return new Connection().exeNonQuery(queryUpdate);
        }
    }
}
