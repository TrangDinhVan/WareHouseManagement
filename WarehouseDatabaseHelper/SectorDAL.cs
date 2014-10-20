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
        OleDbCommand cmd;
        public DataTable getAllSector()
        {
            string queryAll = "select * from [v_sector]";
            return new Connection().getListRecord(queryAll);
        }
        public Sector getOneSection(int SectorID)
        {
            string queryOneSection = string.Format("select * from [sector] where sector_id = {0}", SectorID);
            DataRow r = new Connection().getOneRecord(queryOneSection);
            return new Sector(SectorID, r["sector_name"].ToString(), r["sector_desc"].ToString());
        }
        public int deleteSector(int SectorID)
        {
            string queryDelete = string.Format("delete from [sector] where sector_id = {0}", SectorID);
            return new Connection().exeNonQuery(queryDelete);
        }
        public int insertSector(Sector sec)
        {

            string queryInsert = string.Format("insert into [sector] (sector_name,sector_desc) Values('{0}','{1}')", sec.Name, sec.Desc);
            return new Connection().exeNonQuery(queryInsert);
        }
        
        public int updateSector(Sector sec)
        {
            string queryUpdate = string.Format("update [sector] set sector_name = '{0}', sector_desc='{1}' where sector_id={2}", sec.Name, sec.Desc, sec.Id);
            return new Connection().exeNonQuery(queryUpdate);
        }
        
    }
}
