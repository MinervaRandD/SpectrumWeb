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

        List<FieldSpec> fullDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("TypeCode", "Type<br/>Code", "TypeCode", "center", 48),
            new FieldSpec("Number", "Number<br/>", "Number", "center", 56), // Change to int
            new FieldSpec("ModNmbr", "Mod<br/>Nmbr", "ModNmbr", "center", 48),
            new FieldSpec("RevisionNmbr", "Rev<br/>Nmbr", "RevisionNmbr", "center", 48),
            new FieldSpec("AircraftType", "Acft<br/>Type", "AircraftType", "center", 48),
            new FieldSpec("PartNumber", "Part Nmbr", "PartNumber", "center", 80),
            new FieldSpec("ComplyYN", "Comply<br/>(Y/N)", "ComplyYN", "center", 48, "bool"),
            new FieldSpec("DateEntered", "Date<br/>Entered", "DateEntered", "center", 80, "date"),
            new FieldSpec("ComplianceDate", "Comply<br/>Date", "ComplianceDate", "center", 80, "date"),
            new FieldSpec("DateIssued", "Issued<br/>Date", "DateIssued", "center", 80, "date"),
            new FieldSpec("AtaChap", "Ata<br/>Chap", "AtaChap", "center", 50),
            new FieldSpec("ApplyToSerNmbr", "From<br/>Serial<br/>Nmbr","ApplyToSerNmbr", "center",80),
            new FieldSpec("ThruSerNmbr", "Thru<br/>Serial<br/>Nmbr","ThruSerNmbr", "center", 80),
            new FieldSpec("Description", "Description", "Description", "left", 256),
            new FieldSpec("Resolution", "Prob<br/>Resol", "Resolution", "left", 256), // Needs to be added
            new FieldSpec("AlertYN", "Alert<br/>(Y/N)", "AlertYN", "center", 48, "bool"),
            new FieldSpec("InclInInspec", "Incl<br/>In<br/>Inspec", "InclInInspec", "center", 48, "bool"),
            new FieldSpec("OneTimeInspec", "One<br/>Time<br/>Inspec", "OneTimeInspec", "center", 48, "bool"),
            new FieldSpec("PerformEveryHr", "Perform<br/>Every<br/>Hr", "PerformEveryHr", "center", 48),
            new FieldSpec("PerformEveryCy", "Perform<br/>Every<br/>Cycle", "PerformEveryCy", "center", 48),
            new FieldSpec("PerformEveryWk", "Perform<br/>Every<br/>Week", "PerformEveryWk", "center", 48),
             new FieldSpec("ThresholdHrs", "Thresh<br/>Hrs", "ThresholdHrs", "center", 48),
            new FieldSpec("ThresholdCyc", "Thresh<br/>Cyc", "ThresholdCyc", "center", 48),
            new FieldSpec("ThresholdWks", "Thresh<br/>Wks", "ThresholdWks", "center", 48),
            new FieldSpec("AlsoComplyNmbr1", "Cmpl<br/>Chain<br/>1", "AlsoComplyNmbr1", "center", 52),
            new FieldSpec("AlsoComplyNmbr2", "Cmpl<br/>Chain<br/>2", "AlsoComplyNmbr2", "center", 52),
            new FieldSpec("AlsoComplyNmbr3", "Cmpl<br/>Chain<br/>3", "AlsoComplyNmbr3", "center", 52),
            new FieldSpec("Terminate", "Terminate", "Terminate", "center", 48),
            new FieldSpec("TerminateReason", "Terminate<br/>Reason", "TerminateReason", "left", 128),
            new FieldSpec("DateTerminated", "Date<br/>Term", "DateTerminated", "center", 80, "date")
        };

        public IActionResult ADandSB()
        {
            List<AdAndSb> classList = _context.AdAndSbs.ToList();

            return (new GenericTableController()).GenericTableGenerator(
                fullDisplayFieldList
                , "AD / SB"
                , classList.Select(e => (object)e).ToList());

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

        public IActionResult ADandSBCompliance()
        {
            var classList = (from a in _context.AdAndSbs
                                      select new {
                                          a.PkRecordId
                                          , a.TypeCode
                                          , a.ComplianceDate
                                          , Status = a.DateComp != null ? "Closed" : "Open"
                                          , a.ComplyYN
                                          , a.AlertYN
                                          , a.AircraftType
                                          , a.PartNumber
                                          , a.Description }).ToList();

            return (new GenericTableController()).GenericTableGenerator(
                complianceDisplayFieldList
                , "AD / SB Compliance"
                , classList.Select(e => (object)e).ToList());

        }

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

        public IActionResult ADandSBComplianceWorksheet()
        {
            var classList = (from a in _context.AdAndSbs 
                             //join i in _context.AcTypeInspects on new { a.AircraftType, a.PartNumber} equals new {i.AircraftType , i.PartNumber}
                             join m in _context.AcMasters on a.AircraftType equals m.AircraftType
                             select new {
                                 a.PkRecordId
                                 , a.Number
                                 , a.RevisionNmbr
                                 , a.TypeCode
                                 , Status = a.DateComp != null ? "Closed" : "Open"
                                 , a.DateIssued
                                 , a.DateEntered
                                 , a.ComplianceDate
                                 , m.TailNmbr
                                 , a.AircraftType
                                 , a.ACModNmbr
                                 , a.PartNumber
                                 , a.ApplyToSerNmbr
                                 , a.ThruSerNmbr
                                 , a.ComplyYN
                                 , a.VendorNumber
                                 , a.AlertYN
                                 , a.Description }).ToList();

            return (new GenericTableController()).GenericTableGenerator(
                complianceWorksheetDisplayFieldList
                , "AD / SB Compliance Worksheet"
                , classList.Select(e => (object)e).ToList());

        }
    }
}
