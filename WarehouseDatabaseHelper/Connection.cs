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

        public static string StrCnn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\OneDriveWindows10\IT\5th-term-fall-2014\ISD\WareHouseManagement\WarehouseManagement\WarehouseDatabaseHelper\ISD_ASS_DB.accdb";
        public OleDbConnection Cnn;
        public OleDbCommand cmd;
        public Connection()
        {
            Cnn = new OleDbConnection();
            Cnn.ConnectionString = StrCnn;
        }
    
        private void checkConnection()
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
        public void openConnection()
        {
            checkConnection();
            Cnn.Open();
        }
        public int exeNonQuery(string query)
        {
            openConnection();
            try
            {
                cmd = new OleDbCommand(query, this.Cnn);
                return cmd.ExecuteNonQuery();
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
        public DataTable getListRecord(string query)
        {
            DataTable data = new DataTable();
            openConnection();
            try
            {
                cmd = new OleDbCommand(query, this.Cnn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(data);
            }
            catch (Exception ex)
            {
                throw new Exception("Error get Sector: " + ex.Message);
            }
            finally
            {
                Cnn.Close();
            }
            return data;
        }
        public DataRow getOneRecord(string query)
        {
            openConnection();
            DataTable data = new DataTable();
            try
            {
                cmd = new OleDbCommand(query, this.Cnn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(data);
                DataRow r = data.Rows[0];
                return r;
            }
            catch (Exception ex)
            {
                throw new Exception("Error get one section: " + ex.Message);
            }
            finally
            {
                Cnn.Close();
            }
        }
    }
}
