using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class SquawkMaster
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? SquawkNumber { get; set; }

    public string? TypeCode { get; set; }

    public string? Description { get; set; }

    public string? Resolution { get; set; }

    public short? AtaChapCode { get; set; }

    public DateTime? DateReceived { get; set; }

    public int? ReportedBy { get; set; }

    public DateTime? DateDispDuDef { get; set; }

    public short? FlightLogNmbr { get; set; }

    public int? ItemNmbr { get; set; }

    public short? Flight { get; set; }

    public string? AcType { get; set; }

    public DateTime? DateComp { get; set; }

    public int? WorkOrderNmbr { get; set; }

    public string? PartNumbers { get; set; }

    public bool? EtopsSignificant { get; set; }

    public bool? EtopsConfirmed { get; set; }

    public int? EtopsConfirmedBy { get; set; }

    public bool? EtopsVerified { get; set; }

    public int? EtopsVerifiedBy { get; set; }

    public bool? CatIiiSignif { get; set; }

    public bool? CatIiiVerified { get; set; }

    public bool? CatIiiApproach { get; set; }

    public bool? CatIiiLndgTyp { get; set; }

    public string? TextProbAndResolu { get; set; }

    public short? EngPositionNmbr { get; set; }

    public string? TailNmbr { get; set; }

    public string? City { get; set; }

    public bool? EngineShutDown { get; set; }

    public bool? Approach { get; set; }

    public bool? Landing { get; set; }

    public bool? DelayYN { get; set; }

    public bool? CancellationYN { get; set; }

    public bool? ServiceDiffYN { get; set; }

    public short? AtaChapAndSub { get; set; }

    public short? AtaParagraph { get; set; }

    public string? MinEquipList { get; set; }

    public double? AirframeAtSqwk { get; set; }

    public double? AFWhenDone { get; set; }

    public short? DelayMinutes { get; set; }

    public bool DmiYN { get; set; }

    public string? DmiType { get; set; }

    public string? DmiNumber { get; set; }

    public bool? AuditPrint { get; set; }

    public int? WhoFixed { get; set; }

    public int? FirstInspector { get; set; }

    public int? SecondInspector { get; set; }

    public string? SerialNumbers { get; set; }
}
