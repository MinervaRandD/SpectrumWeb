using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class VendorMaster
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? VendorNumber { get; set; }

    public string? NameItemParty { get; set; }

    public string? ShipToAddr1 { get; set; }

    public string? ShipToAddr2 { get; set; }

    public string? ShipToCity { get; set; }

    public string? ShipToState { get; set; }

    public int? ShipToZipCode { get; set; }

    public int? AtaChaptCode { get; set; }

    public string? Contact { get; set; }

    public int? Phone { get; set; }

    public string? Telex { get; set; }

    public string? Twx { get; set; }

    public string? Cable { get; set; }

    public string? BillToAddr1 { get; set; }

    public string? BillToAddr2 { get; set; }

    public string? BillToCity { get; set; }

    public string? BillingState { get; set; }

    public int? BillingZipCode { get; set; }

    public string? CaseListed { get; set; }

    public string? BillingContact { get; set; }

    public string? SortName { get; set; }

    public string? TermsOfPayment { get; set; }

    public bool? FobDS { get; set; }

    public string? ShipVia { get; set; }

    public double? ReprHrsGuar { get; set; }

    public short? ReprCycGuar { get; set; }

    public int? ReprWksGuar { get; set; }

    public double? PurchHrsGuar { get; set; }

    public short? PurchCycGuar { get; set; }

    public int? PurchWksGuar { get; set; }

    public string? Currency { get; set; }

    public string? ShipTypeCode { get; set; }

    public string? APNameXRef { get; set; }

    public string? ARNameXRef { get; set; }

    public string? CertificateNmbr { get; set; }

    public bool? SendViaMFE { get; set; }

    public string? CaseIdNmbr { get; set; }
}
