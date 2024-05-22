using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class TaskCard
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public int? Revision { get; set; }

    public string? TaskId { get; set; }

    public string? PackageNmbr { get; set; }

    public bool? OneTimeCard { get; set; }

    public string? SeqNmbr { get; set; }

    public DateOnly? IssueDate { get; set; }

    public DateOnly? RevisionDate { get; set; }

    public string? AcftType { get; set; }

    public string? AirframeNmbr { get; set; }

    public string? SrcRef { get; set; }

    public string? CheckName { get; set; }

    public string? Category { get; set; }

    public string? Priority { get; set; }

    public string? MaintManRef { get; set; }

    public string? WorkZone { get; set; }

    public string? Ata { get; set; }

    public string? SignatureMode { get; set; }

    public string? Section { get; set; }

    public string? Station { get; set; }

    public string? JobSummary { get; set; }

    public string? Task { get; set; }

    public string? Interval { get; set; }

    public string? Instructions { get; set; }

    public string? Remarks { get; set; }
}
