using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class AdAndSb
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public int? Number { get; set; }

    public int? ModNmbr { get; set; }

    public string? AircraftType { get; set; }

    public string? Adact1 { get; set; }

    public string? Adact2 { get; set; }

    public string? PartNumber { get; set; }

    public string? TypeCode { get; set; }

    public bool? ComplyYN { get; set; }

    public string? VendorNumber { get; set; }

    public bool? AlertYN { get; set; }

    public DateTime? DateEntered { get; set; }

    public DateTime? DateComp { get; set; }

    public string? Description { get; set; }

    public string? Resolution { get; set; }

    public string? TailNmbrs { get; set; }

    public DateTime? ComplianceDate { get; set; }

    public string? ACModNmbr { get; set; }

    public string? AtaChap { get; set; }

    public double? ThresholdHrs { get; set; }

    public int? ThresholdCyc { get; set; }

    public int? ThresholdWks { get; set; }

    public bool? BridgeToInspec { get; set; }

    public bool? InclInInspec { get; set; }

    public bool? OneTimeInspec { get; set; }

    public string? RevisionNmbr { get; set; }

    public string? AlsoComplyNmbr1 { get; set; }

    public string? AlsoComplyNmbr2 { get; set; }

    public string? AlsoComplyNmbr3 { get; set; }

    public string? AlsoComplyNmbr4 { get; set; }

    public DateTime? DateIssued { get; set; }

    public double? PerformEveryHr { get; set; }

    public short? PerformEveryCy { get; set; }

    public short? PerformEveryWk { get; set; }

    public string? ApplyToSerNmbr { get; set; }

    public string? ThruSerNmbr { get; set; }

    public bool? Terminate { get; set; }

    public string? TerminateReason { get; set; }

    public DateTime? DateTerminated { get; set; }
}
