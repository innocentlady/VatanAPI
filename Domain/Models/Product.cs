using System.Collections.Generic;

namespace VatanAPI.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int CategoryID { get; set; }
        public string ImageURL { get; set; }
        public string CategoryName { get; set; }
    }
}
