using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppForeginKey.Models
{
    public class student
    {
        [Key]
        public int Id { get; set; }

        public String studname { get; set; }

        public String phone { get; set; }

        public int skillid { get; set; }

        [ForeignKey(nameof(skillid))]
        public virtual skill skill { get; set; }
    }
}
