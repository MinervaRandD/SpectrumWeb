using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class UserPermission
{
    public string PkPermissionId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string Permission { get; set; } = null!;
}
