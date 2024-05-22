using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class PartQuotation
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? PartNumberKey { get; set; }

    public string? VendorKey { get; set; }

    public DateOnly? DateKey { get; set; }

    public string? RefNmbrKey { get; set; }

    public string? KeyVendor { get; set; }

    public string? KeyPartNumber { get; set; }

    public string? VendPnSeq { get; set; }

    public int? RefNmbr { get; set; }

    public string? VendorNumber { get; set; }

    public string? UnitOfPurchase { get; set; }

    public double? QuotedPrice { get; set; }

    public int? PurchaseQty { get; set; }

    public string? PnWithPrefix { get; set; }

    public string? CurrencyOfQt { get; set; }

    public string? PartNumber { get; set; }

    public string? Comments { get; set; }
}
