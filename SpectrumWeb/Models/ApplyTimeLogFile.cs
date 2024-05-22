using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class ApplyTimeLogFile
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string TailNmbr { get; set; } = null!;

    public DateOnly DateApplied { get; set; }

    public short? FltNmbr { get; set; }

    public short? LegNmbr { get; set; }

    public double? AFHoursAfter { get; set; }

    public short? AFCycAfter { get; set; }

    public short? AFWksAfter { get; set; }

    public double? RevHrsApplied { get; set; }

    public short? RevCycApplied { get; set; }

    public short? RevWksApplied { get; set; }

    public short? RevDepartures { get; set; }

    public double? NrevHrsApplied { get; set; }

    public short? NrevCycApplied { get; set; }

    public short? NrevWksApplied { get; set; }

    public short? NrevDepartures { get; set; }

    public short? NmbrTimesChanged { get; set; }

    public bool? AFAdjusted { get; set; }

    public DateOnly? UpdatedByUtil { get; set; }

    public bool? FromBulkLoad { get; set; }
}
