using System;
using System.Collections.Generic;

namespace TestDatabaseGenerator.Models;

public partial class PartNumberXref
{
    public long PkTransactId { get; set; }

    public string? Prefix { get; set; }

    public string? PartNumber { get; set; }

    public string? XrefActPartNmbr { get; set; }

    public string? Remarks { get; set; }

    public string? FrstXRef { get; set; }
}
