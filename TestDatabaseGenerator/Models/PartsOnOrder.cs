using System;
using System.Collections.Generic;

namespace TestDatabaseGenerator.Models;

public partial class PartsOnOrder
{
    public long PkTransactId { get; set; }

    public int? Number { get; set; }

    public short? PageNumber { get; set; }

    public string? MultiplePgYN { get; set; }

    public string? VoidCloseFlag { get; set; }

    public string? BuyerCode { get; set; }

    public string? Vendor { get; set; }

    public string? Confirm { get; set; }

    public string? Taxable { get; set; }

    public string? FreeOnBoard { get; set; }

    public string? ContactPerson { get; set; }

    public string? OrderPer { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Status { get; set; }

    public string? PrintFlag { get; set; }

    public string? PartNumber { get; set; }

    public string? QtyOrdered { get; set; }

    public string? QuotedAmnt { get; set; }

    public DateTime? DateDue { get; set; }

    public string? QtyReceived { get; set; }

    public DateTime? DateReceived { get; set; }

    public string? InvoicedAmnt { get; set; }

    public string? QtyOnhandRecvd { get; set; }

    public string? AvgAmntWhenRecvd { get; set; }

    public string? ShipVia { get; set; }

    public string? BuyerNotes7x60 { get; set; }

    public string? Account7x84 { get; set; }

    public string? SpecInstr2x70 { get; set; }

    public string? TypeOfPo { get; set; }

    public string? PoTerms { get; set; }

    public int? SalesOrderNmbr { get; set; }

    public string? InvoiceFlag { get; set; }

    public string? NoCharge { get; set; }

    public string? UseCurx { get; set; }

    public string? CurrencyCode { get; set; }

    public double? ExchangeRate { get; set; }

    public string? EnteredQuote { get; set; }

    public string? OriginalInvoiAmnt { get; set; }

    public string? ItemTask7x322 { get; set; }

    public string? JobCards7x80 { get; set; }

    public string? Freight7x112 { get; set; }

    public string? CstmImpBrkr { get; set; }

    public string? ShpHndl7x112 { get; set; }

    public string? Approved { get; set; }

    public short? RevisionNmbr { get; set; }

    public string? RevisionStatus { get; set; }
}
