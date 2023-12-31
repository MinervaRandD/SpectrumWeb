﻿using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class User
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? CompanyId { get; set; }

    public string Role { get; set; } = null!;

    public string? JobTitle { get; set; }

    public string? Email { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? StateOrRegion { get; set; }

    public string? Country { get; set; }

    public string? PostalCode { get; set; }

    public string? Notes { get; set; }
}
