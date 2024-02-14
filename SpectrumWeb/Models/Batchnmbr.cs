using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class Batchnmbr
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public int? BatchNmbr1 { get; set; }

    public string? Blank { get; set; }

    public string? ItemNmbr { get; set; }

    public string? SerialNmbr { get; set; }

    public string? Description1 { get; set; }

    public string? Rbkey { get; set; }

    public string? Keyword1 { get; set; }

    public string? RefNmbr1 { get; set; }

    public string? PartNmbr1 { get; set; }

    public string? Description2 { get; set; }

    public string? Rkkey { get; set; }

    public string? AtaChapSub { get; set; }

    public string? RefNmbr2 { get; set; }

    public string? Keyword2 { get; set; }

    public string? PartNmbr2 { get; set; }

    public string? Description3 { get; set; }

    public string? Rakey { get; set; }

    public string? Prefix { get; set; }

    public string? PartNumber { get; set; }

    public string? XrefActPartNmbr { get; set; }

    public string? Remarks { get; set; }

    public string? FrstXRef { get; set; }
}
