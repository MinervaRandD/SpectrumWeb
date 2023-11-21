using System;
using System.Collections.Generic;

namespace TestDatabaseGenerator.Models;

public partial class PartsOnAc
{
    public long PkTransactId { get; set; }

    public string? TailNmbr { get; set; }

    public string? Pfitmnmbr { get; set; }

    public string? Position { get; set; }

    public string? Location { get; set; }

    public string? SerialNmbr { get; set; }

    public string? PartNmbrUsed { get; set; }

    public string? SPASupPreAl { get; set; }

    public short? ExpendableQty { get; set; }

    public short? PrimaryPnQty { get; set; }

    public short? AltPnQty { get; set; }
}
