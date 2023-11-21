using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class PartRequisition
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? TypeR { get; set; }

    public int? Number { get; set; }

    public string? RecordCode { get; set; }

    public short? DetailSeqNmbr { get; set; }

    public string? Tskey { get; set; }

    public DateTime? DateEntered { get; set; }

    public DateTime? DateOrdered { get; set; }

    public DateTime? DateLastModif { get; set; }

    public string? Warehouse { get; set; }

    public int? SvcOrdNmbr { get; set; }

    public string? TailNmbr { get; set; }

    public DateTime? DateRequired { get; set; }

    public DateTime? LatestReqDate { get; set; }

    public DateTime? DateCancelled { get; set; }

    public short? NbrOfRecords { get; set; }

    public int? Requestor { get; set; }

    public string? PickedYN { get; set; }

    public string? CompletedYP { get; set; }

    public short? TimeOfOrder { get; set; }

    public string? ShippingMethod { get; set; }

    public string? ShippingWaybil { get; set; }
}
