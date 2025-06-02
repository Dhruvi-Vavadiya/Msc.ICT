using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImageCRUD.Models
{
    public class Tbl_ord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string onm { get; set; }

        public string img { get; set; } // Store image file path as VARCHAR


        [NotMapped] // This prevents it from being mapped to the database
        public IFormFile ImageFile { get; set; }
    }
}
