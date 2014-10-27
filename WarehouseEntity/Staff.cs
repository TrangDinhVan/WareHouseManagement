using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;

namespace WarehouseEntity
{
    public class Staff
    {
        public string[] PermissionSet = { "Admin Manager", "Transactor - Accountant", "Protector - Technician Admin" };
        private string _name;

        public Staff()
        {
            LstUndertakenRepo = new DataTable();
        }

        public int Id { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name must not be empty.");
                _name = value;
            }
        }

        public string Permission { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public DataTable LstUndertakenRepo { get; set; }
    }
}
