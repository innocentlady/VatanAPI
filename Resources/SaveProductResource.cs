using System.ComponentModel.DataAnnotations;

namespace VatanAPI.Resources
{
    public class SaveProductResource
    {
        [Required]
        [MaxLength(30)]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int CategoryID { get; set; }
        public string ImageURL { get; set; }
        public string Detail { get; set; }

    }
}
