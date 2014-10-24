using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;
namespace WarehouseEntity
{
    public class Maintainance
    {
        private int _Id;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private string _Desc;
        private double _Price;
        private Repository _Repo;
        public Maintainance()
        {
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
        public Repository Repo
        {
            get { return _Repo; }
            set { _Repo = value; }
        }
    }
}
