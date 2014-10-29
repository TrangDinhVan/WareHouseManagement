//

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;

namespace WarehouseEntity
{
    public class Repository
    {
        public string[] VolumeSet = { "Small", "Medium", "Big" };

        public Repository()
        {
            Sector = new Sector();
            Staff = new Staff();
            LstMaintain = new DataTable();
            LstOrderDetail = new DataTable();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Repository's Name is required!"), MaxLength(32, ErrorMessage = "Repository's Name is too long!")]
        public string Name { get; set; }

        public string Desc { get; set; }

        public double Price { get; set; }

        public string Volume { get; set; }

        public Sector Sector { get; set; }

        public Staff Staff { get; set; }

        public DataTable LstMaintain { get; set; }

        public DataTable LstOrderDetail { get; set; }

        public double GetTotalMaintainValue()
        {
            return LstMaintain.Rows.Cast<DataRow>().Sum(r => double.Parse(r["maintain_price"].ToString()));
        }

        public Dictionary<DateTime,DateTime> GetMaintainedRanges()
        {
            return LstMaintain.Rows.Cast<DataRow>().ToDictionary(r => Convert.ToDateTime(r["start_date"].ToString()).Date, r => Convert.ToDateTime(r["end_date"].ToString()).Date);
        }
    }
}
