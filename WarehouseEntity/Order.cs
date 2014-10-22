using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;


namespace WarehouseEntity
{
    public class Order
    {
        private int _Id;
        private DateTime _Date;
        private double _Paid;
        private Customer _Customer;
        private DataTable _lstOrderDetail;
        public Order()
        {
            _Customer = new Customer();
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public double Paid
        {
            get { return _Paid; }
            set { _Paid = value; }
        }
        public Customer Customer
        {
            get { return _Customer; }
            set { _Customer = value; }
        }
        public DataTable lstOrderDetail
        {
            get { return _lstOrderDetail; }
            set { _lstOrderDetail = value; }
        }
    }
}
