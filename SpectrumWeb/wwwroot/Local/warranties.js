class WarrantyClass {
    PkRecordId;
    TransactId;
    Number;
    PartNumber;
    SerialNmbr;
    DateReceived;
    HoursGuaranteed;
    CyclesGuaranteed;
    WeeksGuaranteed;
    HoursAtInstall;
    CyclsAtInstall;
    WeeksAtInstall;
    TermsTerminalNmbr;
    Notes;
    ExchangedSerNmbr;
    ControlTag;
    VendorNumber;
    AtaChap;

    constructor(
        pkRecordId,
        transactId,
        number,
        partNumber,
        serialNmbr,
        dateReceived,
        hoursGuaranteed,
        cyclesGuaranteed,
        weeksGuaranteed,
        hoursAtInstall,
        cyclsAtInstall,
        weeksAtInstall,
        termsTerminalNmbr,
        notes,
        exchangedSerNmbr,
        controlTag,
        vendorNumber,
        ataChap
    ) {
        this.PkRecordId = pkRecordId;
        this.TransactId = transactId;
        this.Number = number;
        this.PartNumber = partNumber;
        this.SerialNmbr = serialNmbr;
        this.DateReceived = dateReceived;
        this.HoursGuaranteed = hoursGuaranteed;
        this.CyclesGuaranteed = cyclesGuaranteed;
        this.WeeksGuaranteed = weeksGuaranteed;
        this.HoursAtInstall = hoursAtInstall;
        this.CyclsAtInstall = cyclsAtInstall;
        this.WeeksAtInstall = weeksAtInstall;
        this.TermsTerminalNmbr = termsTerminalNmbr;
        this.Notes = notes;
        this.ExchangedSerNmbr = exchangedSerNmbr;
        this.ControlTag = controlTag;
        this.VendorNumber = vendorNumber;
        this.AtaChap = ataChap;
    }
}
