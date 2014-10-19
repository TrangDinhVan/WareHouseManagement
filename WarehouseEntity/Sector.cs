using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;

namespace WarehouseEntity
{
    public class Sector
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DataTable lstRepo { get; set; }
        public Sector()
        {
            lstRepo = new DataTable();
        }
        public Sector(int id, string name, string desc)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name must not be empty");
            lstRepo = new DataTable();
            Id = id;
            Name = name;
            Desc = desc;
        }
        public Sector(string name, string desc)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name must not be empty");
            this.Name = name;
            this.Desc = desc;
        }
    }
}
