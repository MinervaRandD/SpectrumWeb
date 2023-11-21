using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class InspectionsByPartNmbr
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string InspectionId { get; set; } = null!;

    public string PartNmbr { get; set; } = null!;

    public string SerialNmbr { get; set; } = null!;

    public string InspectionName { get; set; } = null!;

    public string? AcftType { get; set; }

    public string? Description { get; set; }

    public bool? ResetToZero { get; set; }

    public DateTime? LastAppliedOnDate { get; set; }

    public int? HoursCurr { get; set; }

    public short? CyclesCurr { get; set; }

    public short? DaysCurr { get; set; }

    public int? HoursSinceNew { get; set; }

    public short? CyclesSinceNew { get; set; }

    public short? DaysSinceNew { get; set; }

    public int? HoursOverride { get; set; }

    public short? CyclesOverride { get; set; }

    public short? DaysOverride { get; set; }

    public short? PerformedTimes { get; set; }

    public DateTime? LastPerformedOn { get; set; }

    public int? CurrWorkPckgNmbr { get; set; }

    public short? DaysToAccomplish { get; set; }

    public bool? TerminateInspection { get; set; }
}
