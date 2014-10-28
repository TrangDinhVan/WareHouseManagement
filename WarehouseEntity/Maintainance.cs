using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;
namespace WarehouseEntity
{
    public class Maintainance
    {
        public Maintainance()
        {
            Repo = new Repository();
        }

        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Desc { get; set; }

        public double Price { get; set; }

        public Repository Repo { get; set; }

        public bool CheckValidRange()
        {
            Dictionary<DateTime, DateTime> histoyTimes = Repo.GetMaintainRange();
            return false;
        }
    }
}
