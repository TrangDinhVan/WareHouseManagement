//
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WarehouseEntity
{
    public class Sector
    {
        public Sector()
        {
            LstRepo = new DataTable();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Sector's Name is required!"), MaxLength(32, ErrorMessage = "Sector's Name is too long!")]
        public string Name { get; set; }

        public string Desc { get; set; }

        public DataTable LstRepo { get; set; }
    }
}
