using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class InspectionsByTailNmbr
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string InspectionId { get; set; } = null!;

    public string TailNmbr { get; set; } = null!;

    public string InspectionName { get; set; } = null!;

    public string? Description { get; set; }

    public bool? ResetToZero { get; set; }

    public DateOnly? LastAppliedOnDate { get; set; }

    public int? HoursCurr { get; set; }

    public short? CyclesCurr { get; set; }

    public short? DaysCurr { get; set; }

    public int? HoursSinceNew { get; set; }

    public short? CyclesSinceNew { get; set; }

    public short? DaysSinceNew { get; set; }

    public int? HoursCurrAirframe { get; set; }

    public short? CyclesCurrAirframe { get; set; }

    public short? DaysCurrAirframe { get; set; }

    public short? PerformedTimes { get; set; }

    public DateOnly? LastPerformedOn { get; set; }

    public int? CurrWorkPckgNmbr { get; set; }

    public short? DaysToAccomplish { get; set; }

    public bool? TerminateInspection { get; set; }
}
