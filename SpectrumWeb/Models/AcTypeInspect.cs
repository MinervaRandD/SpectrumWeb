using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class AcTypeInspect
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? AircraftType { get; set; }

    public string? InspectName { get; set; }

    public string? Src { get; set; }

    public double? ThresholdHrs { get; set; }

    public int? ThresholdCyc { get; set; }

    public short? ThresholdWks { get; set; }

    public string? ActyAbbreviatn { get; set; }

    public string? TaskCardTieIn { get; set; }

    public string? ResetTo0 { get; set; }

    public double? PerfEveryHrs { get; set; }

    public int? PerfEveryCyc { get; set; }

    public short? PerfEveryWks { get; set; }

    public double? EarlyHrsWindow { get; set; }

    public int? EarlyCycWindow { get; set; }

    public short? EarlyWksWindow { get; set; }

    public double? LateHrsWindow { get; set; }

    public int? LateCycWindow { get; set; }

    public short? LateWksWindow { get; set; }

    public double? RepeatEveryHrs { get; set; }

    public int? RepeatEveryCyc { get; set; }

    public short? RepeatEveryWks { get; set; }

    public short? NmbrOfWorkPacks { get; set; }

    public short? NmbrDaysToAccomp { get; set; }

    public string? Description { get; set; }

    public string? OneTimeInspec { get; set; }

    public string? PartNumber { get; set; }

    public string? PartInstalled { get; set; }

    public string? ScndPartNbr { get; set; }

    public string? ThrdPartNbr { get; set; }

    public string? NoteRevisionNmbr { get; set; }

    public string? AdTerminated { get; set; }

    public DateTime? HardDate { get; set; }
}
