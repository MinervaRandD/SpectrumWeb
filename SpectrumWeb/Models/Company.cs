using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class Company
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? StateOrRegion { get; set; }

    public string? Country { get; set; }

    public string? PostalCode { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? PrimaryPointOfContact { get; set; }

    public string? Email { get; set; }

    public string? WebSite { get; set; }

    public string Role { get; set; } = null!;

    public string PrimaryProduct { get; set; } = null!;

    public string? Notes { get; set; }
}
