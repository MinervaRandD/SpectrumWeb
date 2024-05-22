using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class PartTypeMaster
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? PkPartNumber { get; set; }

    public string? Rwitmx { get; set; }

    public string? Warehouse { get; set; }

    public string? PartDesignator { get; set; }

    public short? QtyOutForRepr { get; set; }

    public short? Allotment { get; set; }

    public short? InSuspense { get; set; }

    public short? OrderQuantity { get; set; }

    public short? RefnmbrLinksFiles { get; set; }

    public int? NumberOfSpares { get; set; }

    public string? Vendor1 { get; set; }

    public string? Vendor2 { get; set; }

    public string? Vendor3 { get; set; }

    public short? CurrentPoNmbr { get; set; }

    public string? CurrentPoType { get; set; }

    public short? LastPoNmbr { get; set; }

    public string? LastPoType { get; set; }

    public double? LastPrice { get; set; }

    public double? CurrentPrice { get; set; }

    public double? AveragePrice { get; set; }

    public bool? PrcBreakAvail { get; set; }

    public string? NotesOnPart { get; set; }

    public double? AvgVendLeadTm { get; set; }

    public double? AvgReprLeadTm { get; set; }

    public DateOnly? LastInventDate { get; set; }

    public short? PhyCycleNmbr { get; set; }

    public DateOnly? LastIssueDate { get; set; }

    public DateOnly? LastRecvdDate { get; set; }

    public double? GLAcctNbr { get; set; }

    public bool? Used { get; set; }

    public string? ShelfLocation { get; set; }

    public string? BinLocation { get; set; }

    public short? QtyOnHand { get; set; }

    public short? QuantityOnOrdr { get; set; }

    public short? OrderLevel { get; set; }

    public int? QtyRequested { get; set; }

    public string? ExtraDta { get; set; }

    public bool? PhyInvActive { get; set; }

    public double? ThreeMosStaticUse { get; set; }

    public double? SixMosStaticUse { get; set; }

    public double? TwelveMoStaticUse { get; set; }

    public DateOnly? DateUpdated { get; set; }

    public string? IssTypeInUse { get; set; }
}
