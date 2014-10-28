using System;
using System.Collections.Generic;
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
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public double Paid { get; set; }

        public Customer Customer { get; set; }

        public DataTable LstOrderDetail { get; set; }
    }
}
