﻿using System;
using System.Collections.Generic;
using System.Text;
//OleDB library
using System.Data.OleDb;
using System.Data;
using WarehouseEntity;

namespace WarehouseDatabaseHelper
{
    /// <summary>
    /// All Operators Manipulating data Repository
    /// </summary>
    public class RepositoryDAL
    {
    
        public DataTable GetAllRepo()
        {
            const string queryAll = "select * from [v_repository]";
            return new Connection().GetListRecord(queryAll);
        }

        public DataTable GetSomeRepo(string query)
        {
            return new Connection().GetListRecord(query);
        }
        public Repository GetOneRepo(int ID)
        {
            string queryOne = string.Format("select * from [repository] where repo_id = {0}", ID);
            DataRow r = new Connection().GetOneRecord(queryOne);
            Repository repo = new Repository
            {
                Id = ID,
                Name = r["repo_name"].ToString(),
                Desc = r["repo_desc"].ToString(),
                Price = double.Parse(r["repo_price"].ToString()),
                Volume = r["repo_volume"].ToString(),
                Sector = new SectorDAL().GetOneSection(int.Parse(r["sector_id"].ToString())),
                Staff = new StaffDAL().GetOneStaff(int.Parse(r["staff_id"].ToString())),
                LstMaintain = new MaintainanceDAL().GetSomeMaintain(string.Format("select * from [maintainance] where repo_id = {0}",ID)),
                LstOrderDetail = new OrderDetailDAL().GetSomeOrderDetail((string.Format("select * from [order_detail] where repo_id = {0}",ID)))
            };
            return repo;
        }
        public int DeleteRepo(int id)
        {
            string queryDelete = string.Format("delete from repository where repo_id = {0}", id);
            return new Connection().ExeNonQuery(queryDelete);
        }
        public int AddRepo(Repository repo)
        {

            string queryAdd = string.Format("insert into [repository] (repo_name, repo_desc, repo_price, repo_volume, staff_id, sector_id) values ('{0}','{1}',{2},'{3}',{4},{5})",repo.Name, repo.Desc, repo.Price, repo.Volume, repo.Staff.Id, repo.Sector.Id);
            return new Connection().ExeNonQuery(queryAdd);
        }
        public int UpdateRepo(Repository repo)
        {
            string queryUpdate = string.Format("update [repository] set repo_name = '{0}' ,repo_desc = '{1}', repo_price = {2}, repo_volume = '{3}', sector_id = {4}, staff_id = {5} where repo_id = {6}", repo.Name, repo.Desc, repo.Price, repo.Volume, repo.Sector.Id, repo.Staff.Id, repo.Id);
            return new Connection().ExeNonQuery(queryUpdate);
        }

        public DataTable GetInUseRepo()
        {
            string today = DateTime.Today.ToShortDateString();
            string queryGetInUse =
                string.Format(
                    "select * from [v_repository] where [Repository ID] in (select repo_id from [order_detail] where #{0}# between start_date and end_date)",
                    today);
            return new Connection().GetListRecord(queryGetInUse);
        }

        public DataTable GetInMaintainRepo()
        {
            string today = DateTime.Today.ToShortDateString();
            string queryGetInMaintain = string.Format("select * from [v_repository] where [Repository ID] in (select repo_id from [maintainance] where #{0}# between start_date and end_date)",today);
            return new Connection().GetListRecord(queryGetInMaintain);
        }

        public DataTable GetFreeRepo()
        {
            string today = DateTime.Today.ToShortDateString();
            string queryGetFree =
                string.Format(
                    "select * from [v_repository] where ( [Repository ID] not in (select repo_id from [maintainance] where #{0}# between start_date and end_date) ) and  ( [Repository ID] not in (select repo_id from [order_detail] where #{0}# between start_date and end_date) )",
                    today);
            return new Connection().GetListRecord(queryGetFree);
        }

        public DataTable GetNearDuedateRepo()
        {
            string today = DateTime.Today.ToShortTimeString();
            string queryGetNearDuedate = string.Format("select * from [v_repository] where [Repository ID] in (select repo_id from [order_detail] where () )");
            throw new Exception("Not Implemented");
        }

        public DataTable GetOverDuedateRepo()
        {
            throw new Exception("Not Implemented");
        }
    }
}
