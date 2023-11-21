using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class SquawkDeferralDateAudit
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? SquawkNumber { get; set; }

    public DateTime? DateDispDuDef { get; set; }

    public DateTime? DateComp { get; set; }

    public string? Sauser { get; set; }

    public string? Saterm { get; set; }

    public int? Satime { get; set; }

    public DateTime? Sadate { get; set; }

    public string? DmiType { get; set; }

    public string? DmiNumber { get; set; }

    public DateTime? NewDate { get; set; }

    public int? NewDataComp { get; set; }

    public string? NewDmiType { get; set; }

    public string? NewDmiNumber { get; set; }

    public string? Saprnt { get; set; }

    public string? TypeOfAction { get; set; }

    public string? PartListChged { get; set; }

    public string? TextNmbrChged { get; set; }

    public string? TailNmbrChged { get; set; }

    public string? AtaChged { get; set; }

    public string? EnginePosChged { get; set; }

    public string? ShutdownChged { get; set; }

    public string? DelayChnged { get; set; }

    public string? CnxChged { get; set; }
}
