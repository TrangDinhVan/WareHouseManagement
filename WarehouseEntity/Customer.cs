using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WarehouseEntity
{
    public class Customer
    {
        public Customer()
        {
            LstOrder=new DataTable();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Customer's Name is required!"), MaxLength(32, ErrorMessage = "Customer's Name is too long!")]
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public string Fax { get; set; }

        public DataTable LstOrder { get; set; }
    }
}
