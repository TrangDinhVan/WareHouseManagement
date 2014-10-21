using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;

namespace WarehouseEntity
{
    public class Sector
    {
        private int _Id;
        private string _Name;
        private string _Desc;
        private DataTable _lstRepo;
        public Sector()
        {
            _lstRepo = new DataTable();
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name must not be empty.");
                _Name = value;
            }
        }
        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }
        public DataTable lstRepo
        {
            get { return _lstRepo; }
            set { _lstRepo = value; }
        }
    }
}
