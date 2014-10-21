using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;

namespace WarehouseEntity
{
    public class Repository
    {
        private int _Id;
        private string _Name;
        private string _Desc;
        private double _Price;
        private string _Volume;
        private Sector _Sector;
        public Repository()
        {
            _Sector = new Sector();
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
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Repository's name must not be empty.");
                _Name = value;
            }
        }
        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }
        public double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public string Volume
        {
            get { return _Volume; }
            set { _Volume = value; }
        }
        public Sector Sector
        {
            get { return _Sector; }
            set { _Sector = value; }
        }
    }
}
