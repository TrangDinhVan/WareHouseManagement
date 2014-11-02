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
        public DataTable GetAllMaintain()
        {
            string queryAll = "select * from [v_maintainance]";
            return new Connection().GetListRecord(queryAll);
        }
        public DataTable GetSomeMaintain(string query)
        {
            return new Connection().GetListRecord(query);
        }
        public Maintainance GetOneMaintain(int ID)
        {
            string queryOne = string.Format("select * from [maintainance] where maintain_id = {0}", ID);
            DataRow r = new Connection().GetOneRecord(queryOne);
            Maintainance maintain = new Maintainance
            {
                Id = ID,
                Desc = r["mainatain_desc"].ToString(),
                Price = double.Parse(r["maintain_price"].ToString()),
                StartDate = Convert.ToDateTime(r["start_date"].ToString()).Date,
                EndDate = Convert.ToDateTime((r["end_date"]).ToString()).Date,
                Repo = new RepositoryDAL().GetOneRepo(int.Parse(r["repo_id"].ToString()))
            };
            return maintain;
        }
        public int DeleteMaintain(int ID)
        {
            string queryDelete = string.Format("delete from repository where repo_id = {0}", ID);
            return new Connection().ExeNonQuery(queryDelete);
        }
        public int CreateMaintain(Maintainance maintain)
        {
            string queryAdd = string.Format("insert into [maintainance] (repo_id, start_date, end_date, maintain_desc, maintain_price) values ({0}, '{1}', '{2}', '{3}', {4})", maintain.Repo.Id, maintain.StartDate.ToShortDateString(), maintain.EndDate.ToShortDateString(), maintain.Desc, maintain.Price);
            return new Connection().ExeNonQuery(queryAdd);
        }

        public int UpdateMaintain(Maintainance maintain)
        {
            string queryUpdate = string.Format("update [maintainance] set repo_id = {0}, start_date = '{1}', end_date = '{2}', maintain_desc = '{3}', maintain_price = {4} where maintain_id = {5}", maintain.Repo.Id, maintain.StartDate.ToShortDateString(), maintain.EndDate.ToShortDateString(), maintain.Desc, maintain.Price, maintain.Id);
            return new Connection().ExeNonQuery(queryUpdate);
        }
    }
}
