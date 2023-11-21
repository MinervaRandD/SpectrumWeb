using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class AtaChapActyReliabilityMonitoring
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public short? AtaCode { get; set; }

    public string? AircraftType { get; set; }

    public string? PartNumber { get; set; }

    public string? PartNmbrAtaGroup { get; set; }

    public short? NbrReliabPoint { get; set; }

    public DateTime? ReliabDate { get; set; }

    public double? CmpRelUprLim { get; set; }

    public double? SqkRelLowLim { get; set; }

    public double? SqkRelUprLim { get; set; }

    public double? CmpGrphLowLim { get; set; }

    public double? GraphIncrement1 { get; set; }

    public double? SqkGrphLowLim { get; set; }

    public double? GraphIncrement2 { get; set; }

    public double? CmpRelLowLim { get; set; }

    public string? MelDefinitions { get; set; }

    public string? FltCycDays { get; set; }

    public string? TimeValue { get; set; }

    public DateTime? DateSet1 { get; set; }

    public DateTime? DateSet2 { get; set; }

    public string? ETopsSignific { get; set; }

    public string? ReliabilityData { get; set; }
}
