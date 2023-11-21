using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class PartRequisitionXRef
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? OrderWhse { get; set; }

    public int? ReqNumber { get; set; }

    public int? SvcOrdNmbr { get; set; }

    public DateTime? DateCancelled { get; set; }

    public string? TailNmbr { get; set; }

    public int? Requestor { get; set; }

    public string? TsalKey { get; set; }
}
