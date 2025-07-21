using System;
using System.Collections.Generic;

namespace MICMExam.Models;

public partial class HelpDeskCall
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerQuery { get; set; } = null!;

    public string TokenNumber { get; set; } = null!;

    public int? AssignedCounterNo { get; set; }

    public string? ExecutiveName { get; set; }

    public string? ResolutionRemarks { get; set; }

    public string? ResolutionStatus { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ResolvedOn { get; set; }
}

public class TokenStatusViewModel
{
   
    public List<CounterStatus> CounterStatuses { get; set; }
}

public class CounterStatus
{
    public int AssignedCounterNo { get; set; }
    public string TokenNumber { get; set; }
    public bool IsInService { get; set; }
}