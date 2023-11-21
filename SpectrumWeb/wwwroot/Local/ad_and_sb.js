class ADandSBClass {
    PkRecordId;
    TransactId;
    Number;
    ModNmbr;
    AircraftType;
    Adact1;
    Adact2;
    PartNumber;
    TypeCode;
    ComplyYN;
    VendorNumber;
    AlertYN;
    DateEntered;
    DateComp;
    Description;
    Resolution;
    TailNmbrs;
    ComplianceDate;
    ACModNmbr;
    AtaChap;
    ThresholdHrs;
    ThresholdCyc;
    ThresholdWks;
    BridgeToInspec;
    OneTimeInspec;
    RevisionNmbr;
    AlsoComplyNmbr1;
    AlsoComplyNmbr2;
    AlsoComplyNmbr3;
    AlsoComplyNmbr4;
    DateIssued;
    PerformEveryHr;
    PerformEveryCy;
    PerformEveryWk;
    ApplyToSerNmbr;
    ThruSerNmbr;
    Terminate;
    TerminateReason;
    DateTerminated;

    constructor(
        pkRecordId,
        transactId,
        number,
        modNmbr,
        aircraftType,
        adact1,
        adact2,
        partNumber,
        typeCode,
        complyYN,
        vendorNumber,
        alertYN,
        dateEntered,
        dateComp,
        description,
        resolution,
        tailNmbrs,
        complianceDate,
        aCModNmbr,
        ataChap,
        thresholdHrs,
        thresholdCyc,
        thresholdWks,
        bridgeToInspec,
        oneTimeInspec,
        revisionNmbr,
        alsoComplyNmbr1,
        alsoComplyNmbr2,
        alsoComplyNmbr3,
        alsoComplyNmbr4,
        dateIssued,
        performEveryHr,
        performEveryCy,
        performEveryWk,
        applyToSerNmbr,
        thruSerNmbr,
        terminate,
        terminateReason,
        dateTerminated
    ) {
        this.PkRecordId = pkRecordId;
        this.TransactId = transactId;
        this.Number = number;
        this.ModNmbr = modNmbr;
        this.AircraftType = aircraftType;
        this.Adact1 = adact1;
        this.Adact2 = adact2;
        this.PartNumber = partNumber;
        this.TypeCode = typeCode;
        this.ComplyYN = formatBooleanAsYN(complyYN);
        this.VendorNumber = vendorNumber;
        this.AlertYN = alertYN;
        this.DateEntered = formatDateTimeAsDate(dateEntered);
        this.DateComp = formatDateTimeAsDate(dateComp);
        this.Description = description;
        this.Resolution = resolution;
        this.TailNmbrs = tailNmbrs;
        this.ComplianceDate = formatDateTimeAsDate(complianceDate);
        this.ACModNmbr = aCModNmbr;
        this.AtaChap = ataChap;
        this.ThresholdHrs = thresholdHrs;
        this.ThresholdCyc = thresholdCyc;
        this.ThresholdWks = thresholdWks;
        this.BridgeToInspec = bridgeToInspec;
        this.OneTimeInspec = formatBooleanAsYN(oneTimeInspec);
        this.RevisionNmbr = revisionNmbr;
        this.AlsoComplyNmbr1 = alsoComplyNmbr1;
        this.AlsoComplyNmbr2 = alsoComplyNmbr2;
        this.AlsoComplyNmbr3 = alsoComplyNmbr3;
        this.AlsoComplyNmbr4 = alsoComplyNmbr3;
        this.DateIssued = formatDateTimeAsDate(dateIssued);
        this.PerformEveryHr = performEveryHr;
        this.PerformEveryCy = performEveryCy;
        this.PerformEveryWk = performEveryWk;
        this.ApplyToSerNmbr = applyToSerNmbr;
        this.ThruSerNmbr = thruSerNmbr;
        this.Terminate = formatBooleanAsYN(terminate);
        this.TerminateReason = terminateReason;
        this.DateTerminated = formatDateTimeAsDate(dateTerminated);
    }
}