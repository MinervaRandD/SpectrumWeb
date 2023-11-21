using System;
using System.Collections.Generic;

namespace TestDatabaseGenerator.Models;

public partial class PartsListRotablesGroup
{
    public long PkTransactId { get; set; }

    public int? RefnmbrLinksFiles { get; set; }

    public string? SerialNmbr { get; set; }

    public string? PartNumber { get; set; }

    public string? PartType { get; set; }

    public string? PartNmbrArray { get; set; }

    public string? SerialNmbrArray { get; set; }

    public string? QtyRequireArry { get; set; }
}
