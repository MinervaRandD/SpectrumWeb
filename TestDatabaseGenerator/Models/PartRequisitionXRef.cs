using System;
using System.Collections.Generic;

namespace TestDatabaseGenerator.Models;

public partial class PartRequisitionXRef
{
    public long PkTransactId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? OrderWhse { get; set; }

    public int? ReqNumber { get; set; }

    public int? SvcOrdNmbr { get; set; }

    public DateTime? DateCancelled { get; set; }

    public string? TailNmbr { get; set; }

    public int? Requestor { get; set; }

    public string? TsalKey { get; set; }
}
