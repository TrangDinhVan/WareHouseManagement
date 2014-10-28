using System;
//
using System.Data;

namespace WarehouseEntity
{
    public class Customer
    {
        private string _Name;

        public int Id { get; set; }

        public string Name
        {
            get { return _Name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Customer's name must not be empty.");
                _Name = value;
            }
        }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public string Fax { get; set; }

        public DataTable LstOrder { get; set; }
    }
}
