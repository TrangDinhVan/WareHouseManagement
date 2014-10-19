using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseEntity
{
    public class Repository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Sector mSector { get; set; }

        public Repository()
        {

        }
        public Repository(int id, string name, Sector sec)
        {
            Id = id;
            Name = name;
            mSector = sec;
        }
    }
}
