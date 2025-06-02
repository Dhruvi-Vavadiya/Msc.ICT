using System.ComponentModel.DataAnnotations;

namespace WebAppForeginKey.Models
{
    public class skill
    {
        [Key]
        public int id { get; set; }

        public String skillname { get; set; }
    }
}
