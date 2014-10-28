using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
//
using System.Data;

namespace WarehouseEntity
{
    public class Staff
    {
        public string[] PermissionSet = { "Admin Manager", "Transactor - Accountant", "Protector - Technician Admin" };

        public Staff()
        {
            LstUndertakenRepo = new DataTable();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Staff's Name is required!"), MaxLength(32, ErrorMessage = "Staff's Name is too long!")]
        public string Name { get; set; }

        public string Permission { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public DataTable LstUndertakenRepo { get; set; }

    }
}
