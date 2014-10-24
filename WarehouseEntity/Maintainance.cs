﻿using System;
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
        public Repository Repo
        {
            get { return _Repo; }
            set { _Repo = value; }
        }
    }
}