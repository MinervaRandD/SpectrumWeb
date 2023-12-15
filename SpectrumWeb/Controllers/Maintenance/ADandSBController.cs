using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace SpectrumWeb.Controllers.Maintenance
{
    public class ADandSBController : Controller
    {
        private readonly ArmsSpectrumDevelopmentContext _context;

        public ADandSBController(ArmsSpectrumDevelopmentContext context)
        {
            _context = context;
        }

        List<FieldSpec> adsbDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("Revision", "Rev", "Revision", "center", 20),
            new FieldSpec("TypeCode", "Type<br/>Code", "TypeCode", "center", 30),
            new FieldSpec("Number", "Number", "Number", "center", 56),
            new FieldSpec("ModNmbr", "Mod<br/>Nmbr", "ModNmbr", "center", 30),
            new FieldSpec("AircraftType", "Acft<br/>Type", "AircraftType", "center", 40),
            new FieldSpec("PartNumber", "Part Nmbr", "PartNumber", "center", 84),
            new FieldSpec("ComplyYN", "Comply<br/>(Y/N)", "ComplyYN", "center", 30, "bool"),
            new FieldSpec("VendorNumber", "Vendor<br/>Nmbr", "VendorNumber", "center", 64),
            new FieldSpec("DateIssued", "Issued<br/>Date", "DateIssued", "center", 68, "date"),
            new FieldSpec("DateEntered", "Date<br/>Entered", "DateEntered", "center", 68, "date"),
            new FieldSpec("ComplianceDate", "Comply<br/>Date", "ComplianceDate", "center", 68, "date"),
            new FieldSpec("DateComplete", "Date<br/>Completed", "DateComplete", "center", 68, "date"),
            new FieldSpec("AtaChap", "Ata<br/>Chap", "AtaChap", "center", 50),
            new FieldSpec("ApplyToSerNmbr", "From<br/>Serial<br/>Nmbr","ApplyToSerNmbr", "center",80),
            new FieldSpec("ThruSerNmbr", "Thru<br/>Serial<br/>Nmbr","ThruSerNmbr", "center", 80),
            new FieldSpec("Description", "Description", "Description", "left", 256),
            new FieldSpec("Resolution", "Prob<br/>Resol", "Resolution", "left", 256), // Needs to be added
            new FieldSpec("AlertYN", "Alert<br/>(Y/N)", "AlertYN", "center", 30, "bool"),
            new FieldSpec("BridgeToInspec", "Bridge<br/>To<br/>Inspect", "BridgeToInspec", "center", 30, "bool"),
            new FieldSpec("InclInInspec", "Incl<br/>In<br/>Inspec", "InclInInspec", "center", 30, "bool"),
            new FieldSpec("OneTimeInspec", "One<br/>Time<br/>Inspec", "OneTimeInspec", "center", 30, "bool"),
            new FieldSpec("PerformEveryHour", "Perform<br/>Every<br/>Hour", "PerformEveryHour", "center", 48),
            new FieldSpec("PerformEveryCycle", "Perform<br/>Every<br/>Cycle", "PerformEveryCycle", "center", 48),
            new FieldSpec("PerformEveryDay", "Perform<br/>Every<br/>Day", "PerformEveryDay", "center", 48),
            new FieldSpec("PerformEveryWeek", "Perform<br/>Every<br/>Week", "PerformEveryWeek", "center", 48),
            new FieldSpec("ThresholdHours", "Thresh<br/>Hours", "ThresholdHours", "center", 48),
            new FieldSpec("ThresholdCycles", "Thresh<br/>Cycles", "ThresholdCycles", "center", 48),
            new FieldSpec("ThresholdDays", "Thresh<br/>Days", "ThresholdDays", "center", 48),
            new FieldSpec("ThresholdWeeks", "Thresh<br/>Weeks", "ThresholdWeeks", "center", 48),
            new FieldSpec("ComplyChain1", "Cmply<br/>Chain<br/>1", "ComplyChain1", "center", 52),
            new FieldSpec("ComplyChain2", "Cmply<br/>Chain<br/>2", "ComplyChain2", "center", 52),
            new FieldSpec("ComplyChain3", "Cmply<br/>Chain<br/>3", "ComplyChain3", "center", 52),
            new FieldSpec("Terminate", "Terminate", "Terminate", "center", 30, "bool"),
            new FieldSpec("TerminateReason", "Terminate<br/>Reason", "TerminateReason", "left", 128),
            new FieldSpec("DateTerminated", "Date<br/>Term", "DateTerminated", "center", 80, "date")
        };

        List<FieldSpec> adsbChildDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("Description", "Description", "Description", "left", 256),
            new FieldSpec("Resolution", "Prob<br/>Resol", "Resolution", "left", 256), // Needs to be added
            new FieldSpec("TerminateReason", "Terminate<br/>Reason", "TerminateReason", "left", 128),
            new FieldSpec("DateTerminated", "Date<br/>Term", "DateTerminated", "center", 80, "date")
        };

        private string adsbChildFieldFormatter =
            "\"<div class='row'>\"\n"
            + "+ \"    <div class='col-1'></div>\"\n"
            + "+ \"    <div class='col-2'>\"\n"
            + "+ \"        <table style='border:2px solid maroon'>\"\n"
            + "+ \"            <tr><td style='text-align:right'>Description:</td><td>\" + d.Description + \"</td></tr>\"\n"
            + "+ \"            <tr><td style='text-align:right'>solution:</td><td>\" + d.Resolution + \"</td></tr>\"\n"
            + "+ \"        </table>\"\n"
            + "+ \"    </div>\"\n"
            + "+ \"    <div class='col-2'>\"\n"
            + "+ \"          <table style='border:2px solid maroon'>\"\n"
            + "+ \"            <tr><td style='text-align:right'>Date Terminated:</td><td>\" + d.DateTerminated + \"</td></tr>\"\n"
            + "+ \"            <tr><td style='text-align:right'>Terminate Reason:</td><td>\" + d.TerminateReason + \"</td></tr>\"\n"
            + "+ \"        </table>\"\n"
            + "+ \"    </div>\"\n"
            + "+ \"</div>\"\n"
            ;

        public IActionResult ADandSB()
        {
            List<AdAndSb> classList = _context.AdAndSbs.ToList();

            return (new GenericTableController()).GenericTableGenerator(
                adsbDisplayFieldList
                , "AD / SB / FCD"
                , classList.Select(e => (object)e).ToList()
                , adsbChildDisplayFieldList
                , adsbChildFieldFormatter);

        }

        List<FieldSpec> complianceDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("TypeCode", "Type<br/>Code", "TypeCode", "center", 48),
            new FieldSpec("ComplianceDate", "Comply<br/>Date", "ComplianceDate", "center", 80, "date"),
            new FieldSpec("Status", "Status", "Status", "center", 80),
            new FieldSpec("ComplyYN", "Comply<br/>(Y/N)", "ComplyYN", "center", 48, "bool"),
            new FieldSpec("AlertYN", "Alert<br/>(Y/N)", "AlertYN", "center", 48, "bool"),
            new FieldSpec("AircraftType", "Acft<br/>Type", "AircraftType", "center", 48),
            new FieldSpec("PartNumber", "Part Nmbr", "PartNumber", "center", 80),
            new FieldSpec("Description", "Description", "Description", "left", 256),

        };

        //public IActionResult ADandSBCompliance()
        //{
        //    var classList = (from a in _context.AdAndSbs
        //                              select new {
        //                                  a.PkRecordId
        //                                  , a.TypeCode
        //                                  , a.ComplianceDate
        //                                  , Status = a.DateComp != null ? "Closed" : "Open"
        //                                  , a.ComplyYN
        //                                  , a.AlertYN
        //                                  , a.AircraftType
        //                                  , a.PartNumber
        //                                  , a.Description }).ToList();

        //    return (new GenericTableController()).GenericTableGenerator(
        //        complianceDisplayFieldList
        //        , "AD / SB Compliance"
        //        , classList.Select(e => (object)e).ToList());

        //}

        List<FieldSpec> complianceWorksheetDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("Number", "Squawk Nmbr", "Number", "center", 80),
            new FieldSpec("RevisionNmbr", "Rev Nmbr", "RevisionNmbr", "center", 80),
            new FieldSpec("DateIssued", "Issued<br/>Date", "DateIssued", "center", 80, "date"),
            new FieldSpec("DateEntered", "Date<br/>Entered", "DateEntered", "center", 80, "date"),
            new FieldSpec("ComplianceDate", "Comply<br/>Date", "ComplianceDate", "center", 80, "date"),
            new FieldSpec("TypeCode", "Type<br/>Code", "TypeCode", "center", 48),
            new FieldSpec("Status", "Status", "Status", "center", 80),
            new FieldSpec("ComplyYN", "Comply<br/>(Y/N)", "ComplyYN", "center", 48, "bool"),
            new FieldSpec("VendorNumber", "Vend Nmbr", "VendorNumber", "center", 48),
            new FieldSpec("AlertYN", "Alert<br/>(Y/N)", "AlertYN", "center", 48, "bool"),
            new FieldSpec("TailNmbr", "Tail Nmbr", "TailNmbr", "center", 48),
            new FieldSpec("AircraftType", "Acft<br/>Type", "AircraftType", "center", 48),
            new FieldSpec("ACModNmbr", "Acft Mod Nmbr", "ACModNmbr", "center", 60),
            new FieldSpec("PartNumber", "Part Nmbr", "PartNumber", "center", 120),
            new FieldSpec("ApplyToSerNmbr", "From Ser Nmbr", "ApplyToSerNmbr", "center", 120),
            new FieldSpec("ThruSerNmbr", "To Ser Nmbr", "ThruSerNmbr", "center", 120),

        };

        //public IActionResult ADandSBComplianceWorksheet()
        //{
        //    var classList = (from a in _context.AdAndSbs 
        //                     //join i in _context.AcTypeInspects on new { a.AircraftType, a.PartNumber} equals new {i.AircraftType , i.PartNumber}
        //                     join m in _context.AcMasters on a.AircraftType equals m.AircraftType
        //                     select new {
        //                         a.PkRecordId
        //                         , a.Number
        //                         , a.RevisionNmbr
        //                         , a.TypeCode
        //                         , Status = a.DateComp != null ? "Closed" : "Open"
        //                         , a.DateIssued
        //                         , a.DateEntered
        //                         , a.ComplianceDate
        //                         , m.TailNmbr
        //                         , a.AircraftType
        //                         , a.ACModNmbr
        //                         , a.PartNumber
        //                         , a.ApplyToSerNmbr
        //                         , a.ThruSerNmbr
        //                         , a.ComplyYN
        //                         , a.VendorNumber
        //                         , a.AlertYN
        //                         , a.Description }).ToList();

        //    return (new GenericTableController()).GenericTableGenerator(
        //        complianceWorksheetDisplayFieldList
        //        , "AD / SB Compliance Worksheet"
        //        , classList.Select(e => (object)e).ToList());

        //}
    }
}
