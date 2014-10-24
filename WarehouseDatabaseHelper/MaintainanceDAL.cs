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
        public int createMaintain(Maintainance maitain)
        {
            string query = string.Format("");
            return new Connection().exeNonQuery(query);
        }

        public int deleteMaintain(Maintainance maintain)
        {
            throw new System.NotImplementedException();
        }

        public DataTable getAllMaintain()
        {
            throw new System.NotImplementedException();
        }

        public Maintainance getOneMaintain(int ID)
        {
            throw new System.NotImplementedException();
        }

        public int getSomeMaintain(string query)
        {
            throw new System.NotImplementedException();
        }

        public int updateMaintain(int ID)
        {
            throw new System.NotImplementedException();
        }
    }
}
