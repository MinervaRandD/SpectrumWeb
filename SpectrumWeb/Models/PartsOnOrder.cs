using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class PartsOnOrder
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? PoNumber { get; set; }

    public short? PageNumber { get; set; }

    public bool? MultiplePgYN { get; set; }

    public bool? VoidCloseFlag { get; set; }

    public string? BuyerCode { get; set; }

    public string? Vendor { get; set; }

    public bool? Confirm { get; set; }

    public bool? Taxable { get; set; }

    public bool? FreeOnBoard { get; set; }

    public string? ContactPerson { get; set; }

    public string? OrderPer { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Status { get; set; }

    public bool? PrintFlag { get; set; }

    public string? PartNumber { get; set; }

    public int? QtyOrdered { get; set; }

    public double? QuotedAmnt { get; set; }

    public DateTime? DateDue { get; set; }

    public int? QtyReceived { get; set; }

    public DateTime? DateReceived { get; set; }

    public double? InvoicedAmnt { get; set; }

    public int? QtyOnhandRecvd { get; set; }

    public double? AvgAmntWhenRecvd { get; set; }

    public string? ShipVia { get; set; }

    public string? BuyerNotes { get; set; }

    public string? Account { get; set; }

    public string? SpecInstr { get; set; }

    public string? TypeOfPo { get; set; }

    public string? PoTerms { get; set; }

    public int? SalesOrderNmbr { get; set; }

    public bool? InvoiceFlag { get; set; }

    public string? NoCharge { get; set; }

    public bool? UseCurx { get; set; }

    public string? CurrencyCode { get; set; }

    public double? ExchangeRate { get; set; }

    public string? EnteredQuote { get; set; }

    public double? OriginalInvoiAmnt { get; set; }

    public string? ItemTask { get; set; }

    public string? JobCards { get; set; }

    public string? Freight { get; set; }

    public string? CstmImpBrkr { get; set; }

    public string? ShpHndl { get; set; }

    public bool? Approved { get; set; }

    public short? RevisionNmbr { get; set; }

    public string? RevisionStatus { get; set; }
}
