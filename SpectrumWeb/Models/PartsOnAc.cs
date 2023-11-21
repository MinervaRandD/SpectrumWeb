using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class PartsOnAc
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? TailNmbr { get; set; }

    public int? Pfitmnmbr { get; set; }

    public string? Position { get; set; }

    public string? Location { get; set; }

    public string? SerialNmbr { get; set; }

    public string? PartNmbrUsed { get; set; }

    public bool? SPASupPreAl { get; set; }

    public short? ExpendableQty { get; set; }

    public short? PrimaryPnQty { get; set; }

    public short? AltPnQty { get; set; }
}
