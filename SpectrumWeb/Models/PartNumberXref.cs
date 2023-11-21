using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class PartNumberXref
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? Prefix { get; set; }

    public string? PartNumber { get; set; }

    public string? XrefActPartNmbr { get; set; }

    public string? Remarks { get; set; }

    public string? FrstXRef { get; set; }
}
