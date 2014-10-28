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
        public int Id { get; set; }

        public string Name { get; set; }

        public string Permission { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public DataTable LstUndertakenRepo { get; set; }

    }
}
