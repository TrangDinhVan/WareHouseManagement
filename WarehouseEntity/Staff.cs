using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;

namespace WarehouseEntity
{
    public class Staff
    {
        public string[] Permission_set = { "Admin Manager", "Transactor - Accountant", "Protector - Technician Admin" };
        private int _Id;
        private string _Name;
        private string _Permission;
        private string _Address;
        private string _Phone;
        private string _Mail;
        private DataTable _lstUndertakenRepo;
        public Staff()
        {
            _lstUndertakenRepo = new DataTable();
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
        public string Permission
        {
            get { return _Permission; }
            set { _Permission = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }
        public DataTable lstUndertakenRepo
        {
            get { return _lstUndertakenRepo; }
            set { _lstUndertakenRepo = value; }
        }

    }
}
