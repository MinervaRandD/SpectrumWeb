using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class Resources1
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public int? RefnmbrLinksFiles { get; set; }

    public string? SerialNmbr { get; set; }

    public string? PartNumber { get; set; }

    public string? StatusState { get; set; }

    public string? ConditionCode { get; set; }

    public int? InspectNmbr { get; set; }

    public string? LastRepairShop { get; set; }

    public short? OverrideMaxCyc { get; set; }

    public DateTime? DateOrdered { get; set; }

    public DateTime? DateReceived { get; set; }

    public double? PurchasePrice { get; set; }

    public string? ShelfLocation { get; set; }

    public string? BinLocation { get; set; }

    public bool? NewUsedConsign { get; set; }

    public short? TearDownRptnmbr { get; set; }

    public string? WarrantyNumber { get; set; }

    public double? HourThisInstl { get; set; }

    public short? KaeCodeNumber { get; set; }

    public string? KaeRefSernmbr { get; set; }

    public string? BorrowedFrom { get; set; }

    public double? HoursSinceNew { get; set; }

    public double? HoursAtInstall { get; set; }

    public double? HoursTso { get; set; }

    public double? CyclsSinceNew { get; set; }

    public double? CyclsAtIntsall { get; set; }

    public short? WeeksSinceNew { get; set; }

    public short? WeeksAtInstall { get; set; }

    public bool? BorrowLoanFlag { get; set; }

    public DateTime? DateInstIssued { get; set; }

    public string? TailNmbr { get; set; }

    public string? PositionOnAC { get; set; }

    public string? LocationOnAC { get; set; }

    public string? CityName { get; set; }

    public int? ControlTagNmbr { get; set; }

    public string? LoanedTo { get; set; }

    public double? HoursTbo { get; set; }

    public double? CyclsTbo { get; set; }

    public short? BorrowLoanNmbr { get; set; }

    public short? TimeInstIn { get; set; }

    public string? RepairTagNmbrPt1 { get; set; }

    public short? RepairTagNmbrPt2 { get; set; }

    public DateTime? RepairDate { get; set; }

    public string? Ref { get; set; }

    public short? PurchaseOrderNmbr { get; set; }

    public bool? TypeAdSb { get; set; }

    public DateTime? AdSbDueDate { get; set; }

    public short? MfrBatchLotNmbr { get; set; }

    public short? WeeksTso { get; set; }

    public short? WeekThisInstal { get; set; }

    public short? WeeksTbo { get; set; }

    public string? SuspDirection { get; set; }

    public string? CategoryType { get; set; }

    public short? AtaOfLastIssu { get; set; }

    public string? AdSbNumber { get; set; }

    public int? LastIssuedOn { get; set; }

    public string? LastIssStatus { get; set; }

    public int? LastReceivedOn { get; set; }

    public string? LastRcvStatus { get; set; }

    public double? TsnAtLastRepr { get; set; }

    public short? TswAtLastRepr { get; set; }

    public string? KnownUnkTsn { get; set; }

    public DateTime? AdSbUpdateFlg { get; set; }

    public short? AtaParagraph { get; set; }

    public double? OrigPurchaseAmnt { get; set; }

    public double? OverrideMaxHrs { get; set; }

    public DateTime? LastInspecDate { get; set; }

    public double? CyclsTso { get; set; }

    public double? CyclThisInstal { get; set; }

    public double? TscAtLastRepr { get; set; }

    public short? OverrideMaxDay { get; set; }

    public DateTime? UpdateCalendar { get; set; }

    public double? CummRprCost { get; set; }

    public string? ModLevel { get; set; }

    public short? NoteRevisionNmbr { get; set; }

    public int? HigherAssmMvmt { get; set; }

    public DateTime? DateFittedKae { get; set; }
}
