using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;

namespace WarehouseEntity
{
    public class OrderDetail
    {
        public OrderDetail()
        {
            Repo = new Repository();
        }
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Order Order { get; set; }

        public Repository Repo { get; set; }

        public bool CheckedOut { get; set; }
        public int GetDuration()
        {
            var difference = EndDate - StartDate;
            return difference.Days;
            
        }
        public double GetPaidMoney()
        {
            return Repo.Price * GetDuration();
        }
        
    }
}
