using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class PartsListRotablesGroup
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public int? RefnmbrLinksFiles { get; set; }

    public string? SerialNmbr { get; set; }

    public string? PartNumber { get; set; }

    public string? PartType { get; set; }

    public string? PartNmbrArray { get; set; }

    public string? SerialNmbrArray { get; set; }

    public string? QtyRequireArry { get; set; }
}
