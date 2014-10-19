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
        OleDbCommand cmd;
        public static string queryAllSector = "select * from [v_section]";
        public DataTable getAllSector()
        {
            DataTable data = new DataTable();
            new Connection().openConnection();
            try
            {
                cmd = new OleDbCommand(queryAllSector, Connection.Cnn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(data);
            }
            catch (Exception ex)
            {
                throw new Exception("Error get Sector: " + ex.Message);
            }
            finally
            {
                Connection.Cnn.Close();
                Connection.Cnn.Dispose();
            }
            return data;
        }
        public int insertSector(Sector sec)
        {
            string strinsert = string.Format("insert into [section] (section_name,section_desc) Values('{0}','{1}')", sec.Name, sec.Desc);
            new Connection().openConnection();
            try
            {
                cmd = new OleDbCommand(strinsert, Connection.Cnn);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Insert section: " + ex.Message);
            }
            finally
            {
                Connection.Cnn.Close();
            }
        }
        public int deleteSector(int SectorID)
        {
            string query = string.Format("delete from [section] where section_id = {0}", SectorID);
            new Connection().openConnection();
            try
            {
                cmd = new OleDbCommand(query, Connection.Cnn);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error delete section: " + ex.Message);
            }
            finally
            {
                Connection.Cnn.Close();
            }
        }
        public int updateSector(Sector sec)
        {
            string queryupdate = string.Format("update [section] set section_name = '{0}', section_desc='{1}' where section_id={2}", sec.Name, sec.Desc, sec.Id);
            new Connection().openConnection();
            try
            {
                cmd = new OleDbCommand(queryupdate, Connection.Cnn);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error update section: " + ex.Message);
            }
            finally
            {
                Connection.Cnn.Close();
            }
        }
        public Sector getOneSection(int SectorID)
        {
            string queryOneSection = string.Format("select * from [section] where section_id = {0}", SectorID);
            new Connection().openConnection();
            try
            {
                DataTable data = new DataTable();
                cmd = new OleDbCommand(queryOneSection, Connection.Cnn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(data);
                DataRow r = data.Rows[0];
                return new Sector(SectorID, r["section_name"].ToString(), r["section_desc"].ToString());
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error get one section: " + ex.Message);
            }
            finally
            {
                Connection.Cnn.Close();
            }
        }
    }
}
