using System;
//
using System.Data;
namespace WarehouseEntity
{
    public class Sector
    {
        private string _name;
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
        public string Desc { get; set; }

        public DataTable LstRepo { get; set; }
    }
}
