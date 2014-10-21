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
    /// All Operations manipulating sectors data
    /// </summary>
    public class SectorDAL
    {
        public DataTable getAllSector()
        {
            string queryAll = "select * from [v_sector]";
            return new Connection().getListRecord(queryAll);
        }
        public DataTable getSomeSector(string query)
        {
            return new Connection().getListRecord(query);
        }
        public Sector getOneSection(int ID)
        {
            string queryOne = string.Format("select * from [sector] where sector_id = {0}", ID);
            DataRow r = new Connection().getOneRecord(queryOne);
            Sector sector = new Sector();
            sector.Id = ID;
            sector.Name = r["sector_name"].ToString();
            sector.Desc = r["sector_desc"].ToString();
            return sector;
        }
        public int deleteSector(int ID)
        {
            string queryDelete = string.Format("delete from [sector] where sector_id = {0}", ID);
            return new Connection().exeNonQuery(queryDelete);
        }
        public int addSector(Sector sec)
        {

            string queryAdd = string.Format("insert into [sector] (sector_name,sector_desc) Values('{0}','{1}')", sec.Name, sec.Desc);
            return new Connection().exeNonQuery(queryAdd);
        }
        
        public int updateSector(Sector sec)
        {
            string queryUpdate = string.Format("update [sector] set sector_name = '{0}', sector_desc='{1}' where sector_id={2}", sec.Name, sec.Desc, sec.Id);
            return new Connection().exeNonQuery(queryUpdate);
        }
        
    }
}
