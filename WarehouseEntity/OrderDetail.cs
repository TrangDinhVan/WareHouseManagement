using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;

namespace WarehouseEntity
{
    public class OrderDetail
    {
        private int _Id;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private Order _Order;
        private Repository _Repo;
        public OrderDetail()
        {
            _Order = new Order();
            _Repo = new Repository();
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }
        public Order Order
        {
            get { return _Order; }
            set { _Order = value; }
        }
        public Repository Repo
        {
            get { return _Repo; }
            set { _Repo = value; }
        }
        public int getDuration()
        {
            TimeSpan difference = _EndDate - _StartDate;
            int days = difference.Days;
            return days;
            
        }
        public double getPaidMoney()
        {
            return _Repo.Price * getDuration();
        }
    }
}
