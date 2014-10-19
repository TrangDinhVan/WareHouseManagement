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

        public static OleDbConnection Cnn;
        const string EX_CONNECT = "Error connect to DB: ";
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
                throw new Exception(EX_CONNECT + ex.Message);
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
    }
}
