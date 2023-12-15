using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class TaskCard
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public int? Revision { get; set; }

    public int? TaskId { get; set; }

    public int? TaskIdSub { get; set; }

    public bool? OneTimeCard { get; set; }

    public string? SeqNmbr { get; set; }

    public DateTime? IssueDate { get; set; }

    public string? AcftType { get; set; }

    public string? SrcRef { get; set; }

    public string? Category { get; set; }

    public string? Priority { get; set; }

    public string? MaintManRef { get; set; }

    public string? WorkZone { get; set; }

    public string? Section1 { get; set; }

    public string? Section2 { get; set; }

    public string? Station1 { get; set; }

    public string? Station2 { get; set; }

    public string? JobSummary { get; set; }

    public string? Task { get; set; }

    public string? Interval { get; set; }

    public string? Instructions { get; set; }

    public string? Remarks { get; set; }
}
