namespace WebApplicationIdentityTupleDynamicPoly.Models
{
    public class Employee : IClassDesign
    {
        public int eid { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public string designation { get; set; }

        public string Display()
        {
            return "eid :-" + eid + "| ename :-" + name + "| salary :-" + salary + "| designation :-" + designation;
        }
    }
}
