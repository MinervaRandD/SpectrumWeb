using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class AdAndSb
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public int? Revision { get; set; }

    public int? Number { get; set; }

    public int? ModNmbr { get; set; }

    public string? AircraftType { get; set; }

    public string? PartNumber { get; set; }

    public string? TypeCode { get; set; }

    public bool? ComplyYN { get; set; }

    public string? VendorNumber { get; set; }

    public bool? AlertYN { get; set; }

    public DateOnly? DateEntered { get; set; }

    public DateOnly? DateComplete { get; set; }

    public string? Description { get; set; }

    public string? Resolution { get; set; }

    public DateOnly? ComplianceDate { get; set; }

    public string? AtaChap { get; set; }

    public double? ThresholdHours { get; set; }

    public int? ThresholdCycles { get; set; }

    public int? ThresholdDays { get; set; }

    public int? ThresholdWeeks { get; set; }

    public bool? BridgeToInspec { get; set; }

    public bool? InclInInspec { get; set; }

    public bool? OneTimeInspec { get; set; }

    public string? ComplyChain1 { get; set; }

    public string? ComplyChain2 { get; set; }

    public string? ComplyChain3 { get; set; }

    public DateOnly? DateIssued { get; set; }

    public double? PerformEveryHour { get; set; }

    public short? PerformEveryCycle { get; set; }

    public short? PerformEveryDay { get; set; }

    public short? PerformEveryWeek { get; set; }

    public string? ApplyToSerNmbr { get; set; }

    public string? ThruSerNmbr { get; set; }

    public bool? Terminate { get; set; }

    public string? TerminateReason { get; set; }

    public DateOnly? DateTerminated { get; set; }
}
