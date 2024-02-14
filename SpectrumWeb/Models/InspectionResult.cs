using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class InspectionResult
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string InspectionId { get; set; } = null!;

    public string? InspectLocation { get; set; }

    public DateTime? InspectDate { get; set; }

    public int? PackageNmbr { get; set; }

    public double? AirframeTotalHours { get; set; }

    public int? AirframeTotalCycles { get; set; }

    public int? AirframeTotalDays { get; set; }

    public double? HoursBeforeReset { get; set; }

    public int? CyclesBeforeReset { get; set; }

    public int? DaysBeforeReset { get; set; }

    public double? HoursAfterReset { get; set; }

    public int? CyclesAfterReset { get; set; }

    public int? DaysAfterReset { get; set; }

    public string? InspectResults { get; set; }

    public bool? Reset { get; set; }

    public DateTime? DeferDate { get; set; }

    public string? DeferReason { get; set; }

    public double? NextRepeatHours { get; set; }

    public int? NextRepeatCycles { get; set; }

    public int? NextRepeatDays { get; set; }
}
