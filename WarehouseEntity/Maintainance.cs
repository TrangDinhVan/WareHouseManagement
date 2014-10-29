using System;
using System.Collections.Generic;
using System.Linq;
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

            Dictionary<DateTime, DateTime> histoyTimes = Repo.GetMaintainedRanges();
            foreach (KeyValuePair<DateTime, DateTime> range in histoyTimes.Where(range => 
                (EndDate.Date == range.Key.Date || EndDate.Date == range.Value.Date)
                || (StartDate.Date == range.Key.Date || StartDate.Date == range.Value.Date) 
                || (StartDate.Date > range.Key.Date && StartDate.Date < range.Value.Date) 
                || (EndDate.Date > range.Key.Date && EndDate.Date < range.Value.Date) ))
            {
                throw new Exception(string.Format("This Repository has already had a maintainance from {0} to {1}",range.Key.ToShortDateString(),range.Value.ToShortDateString()));
            }
            return true;
        }
    }
}
