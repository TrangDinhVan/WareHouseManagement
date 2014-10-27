using System;
//
using System.Data;

namespace WarehouseEntity
{
    public class Repository
    {
        public string[] VolumeSet = { "Small", "Medium", "Big" };
        private string _name;

        public Repository()
        {
            Sector = new Sector();
            Staff = new Staff();
            LstMaintain = new DataTable();
        }

        public int Id { get; set; }

        public string Name
        {
            get { return _name; }
            set 
            { 
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Repository's name must not be empty.");
                _name = value;
            }
        }

        public string Desc { get; set; }

        public double Price { get; set; }

        public string Volume { get; set; }

        public Sector Sector { get; set; }

        public Staff Staff { get; set; }

        public DataTable LstMaintain { get; set; }

        public DataTable LstOrderDetail { get; set; }

        public double GetTotalMaintainValue()
        {
            double total = 0;
            foreach (DataRow r in LstMaintain.Rows)
            {
                total += double.Parse(r["maintain_price"].ToString());
            }
            return total;
        }
    }
}
