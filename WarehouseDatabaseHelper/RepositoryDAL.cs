using System;
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
    
        public DataTable getAllRepo()
        {
            string queryAll = "select * from [v_repository_sector]";
            return new Connection().getListRecord(queryAll);
        }
        public DataTable getSomeRepo(string query)
        {
            return new Connection().getListRecord(query);
        }
        public Repository getOneRepo(int ID)
        {
            string queryOne = string.Format("select * from [repository] where repo_id = {0}", ID);
            DataRow r = new Connection().getOneRecord(queryOne);
            Repository repo = new Repository();
            repo.Id = ID;
            repo.Name = r["repo_name"].ToString();
            repo.Desc = r["repo_desc"].ToString();
            repo.Price = double.Parse( r["repo_price"].ToString() );
            repo.Volume = r["repo_volume"].ToString();
            repo.Sector = new SectorDAL().getOneSection(int.Parse(r["sector_id"].ToString()));
            repo.Staff = new StaffDAL().getOneStaff(int.Parse(r["staff_id"].ToString()));
            return repo;
        }
        public int deleteRepo(int ID)
        {
            string queryDelete = string.Format("delete from repository where repo_id = {0}", ID);
            return new Connection().exeNonQuery(queryDelete);
        }
        public int addRepo(Repository Repo)
        {

            string queryAdd = string.Format("insert into [repository] (repo_name, repo_desc, repo_price, repo_volume, staff_id, sector_id) values ('{0}','{1}',{2},'{3}',{4},{5})",Repo.Name, Repo.Desc, Repo.Price, Repo.Volume, Repo.Staff.Id, Repo.Sector.Id);
            return new Connection().exeNonQuery(queryAdd);
        }
        public int updateRepo(Repository Repo)
        {
            string queryUpdate = string.Format("update [repository] set repo_name = '{0}' ,repo_desc = '{1}', repo_price = {2}, repo_volume = '{3}', sector_id = {4}, staff_id = {5} where repo_id = {6}", Repo.Name, Repo.Desc, Repo.Price, Repo.Volume, Repo.Sector.Id, Repo.Staff.Id, Repo.Id);
            return new Connection().exeNonQuery(queryUpdate);
        }
    }
}
