using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class Atachap
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public double? ChapNmbr { get; set; }

    public string? ChapName { get; set; }
}
