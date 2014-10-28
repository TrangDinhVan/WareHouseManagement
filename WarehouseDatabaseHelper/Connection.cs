using System;
using System.Collections.Generic;
using System.Text;
//OleDB library
using System.Data.OleDb;
using System.Data;
using System.IO;


namespace WarehouseDatabaseHelper
{
    public class Connection
    {

        //public static string StrCnn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\OneDriveWindows10\IT\5th-term-fall-2014\ISD\WareHouseManagement\WarehouseManagement\WarehouseDatabaseHelper\ISD_ASS_DB.accdb";
        public static string StrCnn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\WareHouse.accdb";
        public OleDbConnection Cnn;
        public OleDbCommand Cmd;
        public Connection()
        {
            Cnn = new OleDbConnection {ConnectionString = StrCnn};
        }
    
        private void CheckConnection()
        {
            try
            {
                Cnn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Error connect to DB: " + ex.Message);
            }
            finally
            {
                if (Cnn.State == ConnectionState.Open)
                {
                    Cnn.Close();
                }
            }
        }
        public void OpenConnection()
        {
            CheckConnection();
            Cnn.Open();
        }
        public int ExeNonQuery(string query)
        {
            OpenConnection();
            try
            {
                Cmd = new OleDbCommand(query, Cnn);
                return Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error exeNonQuery: " + ex.Message);
            }
            finally
            {
                Cnn.Close();
            }
        }
        public DataTable GetListRecord(string query)
        {
            DataTable data = new DataTable();
            try
            {
                Cmd = new OleDbCommand(query, Cnn);
                OleDbDataAdapter da = new OleDbDataAdapter(Cmd);
                da.Fill(data);
            }
            catch (Exception ex)
            {
                throw new Exception("Error get Sector: " + ex.Message);
            }
            return data;
        }
        public DataRow GetOneRecord(string query)
        {
            DataTable data = new DataTable();
            try
            {
                Cmd = new OleDbCommand(query, Cnn);
                OleDbDataAdapter da = new OleDbDataAdapter(Cmd);
                da.Fill(data);
                DataRow r = data.Rows[0];
                return r;
            }
            catch (Exception ex)
            {
                throw new Exception("Error get one section: " + ex.Message);
            }
        }
    }
}
