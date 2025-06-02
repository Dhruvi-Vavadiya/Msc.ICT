using ExampleExpenseAPI.Models;

namespace ExampleExpenseAPI.DTO
{
    public class EinformationDTO
    {
        public int Eid { get; set; }

        public int? Uid { get; set; }

        public DateOnly? Date { get; set; }

        public double? Amount { get; set; }

        
    }
}
