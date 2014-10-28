using System;
using System.Collections.Generic;
using System.Text;
//OleDB library
using System.Data.OleDb;
using System.Data;
using WarehouseEntity;

namespace WarehouseDatabaseHelper
{
    public class SectorDAL
    {
    
        public DataTable GetAllSector()
        {
            string queryAll = "select * from [v_sector]";
            return new Connection().getListRecord(queryAll);
        }
        public DataTable getSomeSector(string query)
        {
            return new Connection().getListRecord(query);
        }
        public Sector GetOneSection(int ID)
        {
            string queryOne = string.Format("select * from [sector] where sector_id = {0}", ID);
            DataRow r = new Connection().getOneRecord(queryOne);
            DataTable lstRepo = new RepositoryDAL().GetSomeRepo(string.Format("select * from [repository] where sector_id = {0}",ID));
            Sector sector = new Sector
            {
                Id = ID,
                Name = r["sector_name"].ToString(),
                Desc = r["sector_desc"].ToString(),
                LstRepo = lstRepo
            };
            return sector;
        }
        public int DeleteSector(int ID)
        {
            string queryDelete = string.Format("delete from [sector] where sector_id = {0}", ID);
            return new Connection().exeNonQuery(queryDelete);
        }
        public int AddSector(Sector sec)
        {

            string queryAdd = string.Format("insert into [sector] (sector_name,sector_desc) Values('{0}','{1}')", sec.Name, sec.Desc);
            return new Connection().exeNonQuery(queryAdd);
        }
        
        public int UpdateSector(Sector sec)
        {
            string queryUpdate = string.Format("update [sector] set sector_name = '{0}', sector_desc='{1}' where sector_id={2}", sec.Name, sec.Desc, sec.Id);
            return new Connection().exeNonQuery(queryUpdate);
        }
        
    }
}
