using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;

namespace WarehouseEntity
{
    public class Customer
    {
        private int _Id;
        private string _Name;
        private string _Address;
        private string _Phone;
        private string _Mail;
        private string _Fax;
        private DataTable _lstOrder;
        public Customer()
        {
            _lstOrder = new DataTable();
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
                    throw new Exception("Customer's name must not be empty.");
                _Name = value;
            }
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
        public string Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }
        public DataTable lstOrder
        {
            get { return _lstOrder; }
            set { _lstOrder = value; }
        }
        public double getTotalOrderValue()
        {
            double total = 0;
            
            return total;
        }
    }
}
