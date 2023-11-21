using System;
using System.Collections.Generic;

namespace TestDatabaseGenerator.Models;

public partial class PartsMaster
{
    public long PkTransactId { get; set; }

    public string? PartNumber { get; set; }

    public string? Rwitmx { get; set; }

    public string? Rwwhse { get; set; }

    public string? PartDesignator { get; set; }

    public short? QtyOutForRepr { get; set; }

    public short? Allotment { get; set; }

    public short? InSuspense { get; set; }

    public short? OrderQuantity { get; set; }

    public short? RefnmbrLinksFiles { get; set; }

    public int? NumberOfSpares { get; set; }

    public string? VendorNumber { get; set; }

    public string? VendorNumber1 { get; set; }

    public string? VendorNumber2 { get; set; }

    public short? CurrentPoNmbr { get; set; }

    public string? CurrentPoType { get; set; }

    public short? LastPoNmbr { get; set; }

    public string? LastPoType { get; set; }

    public double? LastPrice { get; set; }

    public double? CurrentPrice { get; set; }

    public double? AveragePrice { get; set; }

    public string? PrcBreakAvail { get; set; }

    public string? NotesOnPart { get; set; }

    public double? AvgVendLeadTm { get; set; }

    public double? AvgReprLeadTm { get; set; }

    public DateTime? LastInventDate { get; set; }

    public short? PhyCycleNmbr { get; set; }

    public DateTime? LastIssueDate { get; set; }

    public DateTime? LastRecvdDate { get; set; }

    public double? GLAcctNbr { get; set; }

    public string? UsedField { get; set; }

    public string? ShelfLocation { get; set; }

    public string? BinLocation { get; set; }

    public short? QtyOnHand { get; set; }

    public short? QuantityOnOrdr { get; set; }

    public short? OrderLevel { get; set; }

    public int? QtyRequested { get; set; }

    public string? ExtraDta { get; set; }

    public string? PhyInvActive { get; set; }

    public double? ThreeMosStaticUse { get; set; }

    public double? SixMosStaticUse { get; set; }

    public double? TwelveMoStaticUse { get; set; }

    public DateTime? DateUpdated { get; set; }

    public string? IssTypeInUse { get; set; }
}
