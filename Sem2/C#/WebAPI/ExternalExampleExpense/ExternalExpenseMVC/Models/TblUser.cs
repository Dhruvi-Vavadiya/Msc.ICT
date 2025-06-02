namespace ExternalExpenseMVC.Models
{
    public class TblUser
    {
        public int Uid { get; set; }

        public string? Uname { get; set; }

        public virtual ICollection<Einformation> Einformations { get; set; } = new List<Einformation>();
    }
}
