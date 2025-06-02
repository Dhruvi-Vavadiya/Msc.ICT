namespace WebApplicationIdentityTupleDynamicPoly.Models
{
    public class Studnet : IClassDesign
    {
        public int sid { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string semester { get; set; }
        public string Display()
        {
            return "sid :- " + sid + "|  sname :- " + name + "| age :- " + age + "| semester :- " + semester;
        }
    }
}
