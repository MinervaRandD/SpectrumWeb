using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class Inspection
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? InspectionName { get; set; }

    public string? Description { get; set; }

    public string? AcftType { get; set; }

    public bool? IncludeOnTaskCard { get; set; }

    public bool? OneTimeInspection { get; set; }

    public bool? ResetToZero { get; set; }

    public short? PerfEveryHours { get; set; }

    public short? PerfEveryCycles { get; set; }

    public short? PerfEveryDays { get; set; }

    public short? EarlyWindEveryHours { get; set; }

    public short? EarlyWindEveryCycles { get; set; }

    public short? EarlyWindEveryDays { get; set; }

    public short? LateWindEveryHours { get; set; }

    public short? LateWindEveryCycles { get; set; }

    public short? LateWindEveryDays { get; set; }

    public short? RepeatEveryHours { get; set; }

    public short? RepeatEveryCycles { get; set; }

    public short? RepeatEveryDays { get; set; }

    public short? ThreshHours { get; set; }

    public short? ThreshCycles { get; set; }

    public short? ThreshDays { get; set; }

    public short? WorkPackages { get; set; }

    public DateOnly? ComplDate { get; set; }

    public string? PartNmbr1 { get; set; }

    public string? PartNmbr2 { get; set; }

    public string? PartNmbr3 { get; set; }
}
