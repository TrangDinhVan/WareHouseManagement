using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Data;


namespace WarehouseEntity
{
    public class Order
    {
        public Order()
        {
            Customer = new Customer();
            LstOrderDetail = new DataTable();
            Staff = new Staff();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public double Paid { get; set; }

        public Customer Customer { get; set; }

        public Staff Staff { get; set; }

        public DataTable LstOrderDetail { get; set; }
    }
}
