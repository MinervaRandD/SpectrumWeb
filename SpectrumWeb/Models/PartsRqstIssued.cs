using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class PartsRqstIssued
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public DateTime? DateOfIssue { get; set; }

    public int? IssueNumber { get; set; }

    public string? RecordCode { get; set; }

    public short? QtyRequested { get; set; }

    public string? Usage { get; set; }

    public int? WorkOrderNmbr { get; set; }

    public int? ReqNmbr { get; set; }

    public short? IssueType { get; set; }

    public short? SourceCode { get; set; }

    public string? BorrowLoanFlag { get; set; }

    public string? SerialNmbr { get; set; }

    public int? ControlTagNmbr { get; set; }

    public short? InspecNmbr { get; set; }

    public string? TailNmbr { get; set; }

    public double? AveragePrice { get; set; }

    public string? Rotable { get; set; }

    public short? ReleaseNoteNmbr { get; set; }

    public double? AccountNumber { get; set; }

    public DateTime? DateReturned { get; set; }

    public int? ReturnNmbr { get; set; }

    public string? KaeSerialNmbr { get; set; }

    public string? LocationCity { get; set; }

    public double? SalesPrice { get; set; }

    public string? CustomerId { get; set; }

    public string? AirwayBill { get; set; }

    public short? AtaCode { get; set; }

    public string? StmBilledOn { get; set; }

    public string? TaskCardId { get; set; }

    public short? SalOrdLineNmbr { get; set; }

    public string? SalOrdLinePut { get; set; }

    public string? SerialCategory { get; set; }

    public string? CatGroup { get; set; }

    public string? PartNumber { get; set; }

    public string? KaeNumber { get; set; }

    public int? JobCardNmbr { get; set; }

    public int? VendorBatchNmbr { get; set; }

    public string? RetToVendNmbr { get; set; }

    public string? Isuser { get; set; }

    public string? RepOrdNmbr { get; set; }
}
