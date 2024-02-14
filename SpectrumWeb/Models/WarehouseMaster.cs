using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class WarehouseMaster
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? WarehouseCode { get; set; }

    public string? WarehouseName { get; set; }

    public string? SystemPrinter { get; set; }

    public string? RepairPrinter { get; set; }

    public string? POPrinter { get; set; }

    public string? IssuePrinter { get; set; }

    public string? RcptPrinter { get; set; }

    public string? ReprShipTkt { get; set; }

    public string? PickTkt { get; set; }

    public string? Contact { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? StateOrRegion { get; set; }

    public string? PostalCode { get; set; }

    public string? TelNmbr { get; set; }

    public string? Department { get; set; }

    public string? Description { get; set; }
}
