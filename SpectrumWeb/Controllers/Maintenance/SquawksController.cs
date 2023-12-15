using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace SpectrumWeb.Controllers.Maintenance
{
    public class SquawksController : Controller
    {
        private readonly ArmsSpectrumDevelopmentContext _context;

        public SquawksController(ArmsSpectrumDevelopmentContext context)
        {
            _context = context;
        }

        List<FieldSpec> squawksMasterDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("Rev", "Rev", "Revision", "center", 20),
            new FieldSpec("SquawkNumber", "Squawk<br/>Number", "SquawkNumber", "right", 60),
            new FieldSpec("TypeCode", "Type<br/>Code", "TypeCode", "center", 30),
            new FieldSpec("Description", "Description", "Description", "left", 240),
            new FieldSpec("TailNmbr", "Tail<br/>Nmbr", "TailNmbr", "center", 60),
            new FieldSpec("AtaChapAndSub", "Ata", "AtaChapAndSub", "center", 50),
            new FieldSpec("DateReceived", "Date<br/>Received", "DateReceived", "center", 72, "date"),
            new FieldSpec("ReportedBy", "Report By", "ReportedBy", "right", 64),
            new FieldSpec("DateDeferred", "Date<br>Deferred To", "DateDeferred", "center", 72, "date"),
            new FieldSpec("Flight", "Flight<br/>Nmbr", "Flight", "center", 60),
            new FieldSpec("AcType", "A/C<br/>Type", "AcType", "center", 60),
            new FieldSpec("MinEqpList", "Min<br/>Equip<br/>List", "MinEquipList", "center", 60),
            new FieldSpec("AFAtSqwk", "Airframe<br/>At Squawk", "AirframeAtSqwk", "center", 60),
            new FieldSpec("AFWhenDone", "Airframe<br/>At<br/>Completion", "AFWhenDone", "center", 60),
            new FieldSpec("FlightLogNmbr", "Flight<br/>Log<br/>Nmbr", "FlightLogNmbr", "center", 80),
            new FieldSpec("LogItemNmbr", "Log<br/>Item Nmbr", "ItemNmbr", "center", 80),
            new FieldSpec("City", "City", "City", "center", 40),
            new FieldSpec("DmiYN", "DMI<br/>Item<br/>(Y/N)", "DmiYN", "center", 40, "bool"),
            new FieldSpec("DmiType", "DMI<br/>Type", "DmiType", "center", 50),
            new FieldSpec("DmiNumber", "DMI<br/>Nmbr", "DmiNumber", "right", 60),
            new FieldSpec("EngPositionNmbr", "Eng<br/>Posn<br/>Nmbr", "EngPositionNmbr", "right", 30),
            new FieldSpec("DelayYN", "Delay<br/>(Y/N)", "DelayYN", "center", 40, "bool"),
            new FieldSpec("DelayMinutes", "Delay<br/>Mins", "DelayMinutes", "right", 40),
            new FieldSpec("CancellationYN", "Cancel<br/>(Y/N)", "CancellationYN", "center", 40, "bool"),
            new FieldSpec("ServiceDiffYN", "Svc<br/>Diff<br/>(Y/N)", "ServiceDiffYN", "center", 40, "bool"),
            new FieldSpec("EngineShutDown", "Engine<br/>Shut<br/>Down", "EngineShutDown", "center", 40, "bool"),
            new FieldSpec("Approach", "Aprch", "Approach", "center", 40, "bool"),
            new FieldSpec("Landing", "Land", "Landing", "center", 40, "bool"),
            new FieldSpec("CatIiiSignif", "Cat<br/>III<br/>Signif", "CatIiiSignif", "center", 40, "bool"),
            new FieldSpec("CatIiiVerified", "Cat<br/>III<br/>Verified", "CatIiiVerified", "center", 40, "bool"),
            new FieldSpec("CatIiiApproach", "Cat<br/>III<br/>Approach", "CatIiiApproach", "center", 40, "bool"),
            new FieldSpec("CatIiiLanding", "Cat<br/>III<br/>Landing", "CatIiiLndgTyp", "center", 40, "bool"),
            new FieldSpec("EtopsSignificant", "Etops<br/>Signif", "EtopsSignificant", "center", 40, "bool"),
            new FieldSpec("EtopsConfirmed", "Etops<br/>Conf", "EtopsConfirmed", "center", 40, "bool"),
            new FieldSpec("EtopsConfirmedBy", "Etops<br/>Conf<br/>By", "EtopsConfirmedBy", "right", 60),
            new FieldSpec("EtopsVerified", "Etops<br/>Verified", "EtopsVerified", "center", 40, "bool"),
            new FieldSpec("EtopsVerifiedBy", "Etops<br/>Verified<br/>By", "EtopsVerifiedBy", "right", 60),
            new FieldSpec("AuditPrint", "Audit<br/>Print", "AuditPrint", "center", 40, "bool"),
            new FieldSpec("DateComp", "Date<br/>Completed", "DateComp", "center", 72),
            new FieldSpec("Resolution", "Resolution", "Resolution", "left", 240),
            new FieldSpec("WhoFixed", "Fixed<br/>By", "WhoFixed", "center", 80),
            new FieldSpec("WorkOrderNmbr", "Work<br/>Order<br/>Nmbr", "WorkOrderNmbr", "center"),
            new FieldSpec("MaintTaskCode", "Maint<br/>Task<br/>Code", "MaintTaskCode", "center"),
            new FieldSpec("FirstInspector", "Inspector 1", "FirstInspector", "center"),
            new FieldSpec("SecondInspector", "Inspector 2", "SecondInspector", "center"),
            new FieldSpec("PartNumber01", "Part<br/>Nmbr 1", "PartNumber01", "center", 60),
            new FieldSpec("PartNumber02", "Part<br/>Nmbr 2", "PartNumber02", "center", 60),
            new FieldSpec("PartNumber03", "Part<br/>Nmbr 3", "PartNumber03", "center", 60),
            new FieldSpec("PartNumber04", "Part<br/>Nmbr 4", "PartNumber04", "center", 60),
            new FieldSpec("PartNumber05", "Part<br/>Nmbr 5", "PartNumber05", "center", 60),
            new FieldSpec("Warehouse01", "Warehouse<br/>1", "Warehouse01", "center", 40),
            new FieldSpec("Warehouse02", "Warehouse<br/>2", "Warehouse02", "center", 40),
            new FieldSpec("Warehouse03", "Warehouse<br/>3", "Warehouse03", "center", 40),
            new FieldSpec("Warehouse04", "Warehouse<br/>4", "Warehouse04", "center", 40),
            new FieldSpec("Warehouse05", "Warehouse<br/>1", "Warehouse05", "center", 40),
            new FieldSpec("SerialNumber01", "Serial<br/>Nmbr<br/>1", "SerialNumber01", "center"),
            new FieldSpec("SerialNumber02", "Serial<br/>Nmbr<br/>2", "SerialNumber02", "center"),
            new FieldSpec("SerialNumber03", "Serial<br/>Nmbr<br/>3", "SerialNumber03", "center"),
            new FieldSpec("SerialNumber04", "Serial<br/>Nmbr<br/>4", "SerialNumber04", "center"),
            new FieldSpec("SerialNumber05", "Serial<br/>Nmbr<br/>5", "SerialNumber05", "center"),

        };

        List<FieldSpec> squawkMasterChildRows = new List<FieldSpec>()
        {
            new FieldSpec("Description", "Description", "Description", "left", 240),
            new FieldSpec("WhoFixed", "Fixed<br/>By", "WhoFixed", "center"),
             new FieldSpec("DateComp", "Date<br/>Completed", "DateComp", "center"),
            new FieldSpec("Resolution", "Resolution", "Resolution", "left", 240),
            new FieldSpec("WorkOrderNmbr", "Work<br/>Order<br/>Nmbr", "WorkOrderNmbr", "center"),
            new FieldSpec("MaintTaskCode", "Maint<br/>Task<br/>Code", "MaintTaskCode", "center"),
            new FieldSpec("FirstInspector", "Inspector 1", "FirstInspector", "center"),
            new FieldSpec("SecondInspector", "Inspector 2", "SecondInspector", "center"),
            new FieldSpec("PartNumber01", "Part<br/>Nmbr 1", "PartNumber01", "center", 60),
            new FieldSpec("PartNumber02", "Part<br/>Nmbr 2", "PartNumber02", "center", 60),
            new FieldSpec("PartNumber03", "Part<br/>Nmbr 3", "PartNumber03", "center", 60),
            new FieldSpec("PartNumber04", "Part<br/>Nmbr 4", "PartNumber04", "center", 60),
            new FieldSpec("PartNumber05", "Part<br/>Nmbr 5", "PartNumber05", "center", 60),
            new FieldSpec("Warehouse01", "Warehouse<br/>1", "Warehouse01", "center", 40),
            new FieldSpec("Warehouse02", "Warehouse<br/>2", "Warehouse02", "center", 40),
            new FieldSpec("Warehouse03", "Warehouse<br/>3", "Warehouse03", "center", 40),
            new FieldSpec("Warehouse04", "Warehouse<br/>4", "Warehouse04", "center", 40),
            new FieldSpec("Warehouse05", "Warehouse<br/>1", "Warehouse05", "center", 40),
            new FieldSpec("SerialNumber01", "Serial<br/>Nmbr<br/>1", "SerialNumber01", "center"),
            new FieldSpec("SerialNumber02", "Serial<br/>Nmbr<br/>2", "SerialNumber02", "center"),
            new FieldSpec("SerialNumber03", "Serial<br/>Nmbr<br/>3", "SerialNumber03", "center"),
            new FieldSpec("SerialNumber04", "Serial<br/>Nmbr<br/>4", "SerialNumber04", "center"),
            new FieldSpec("SerialNumber05", "Serial<br/>Nmbr<br/>5", "SerialNumber05", "center"),
           
        };


        private string squawkChildFieldFormatter =
            "\"<h6 style='color:maroon'>Description</h6>\"\n"
            + "+ \"<div style='height:80px;width:50%;margin-top:10px;margin-left:32px;margin-bottom:10px;padding:4px;border:2px solid maroon;border-radius:4px'>\" + d.Description + \"</div>\"\n"
            + "+ \"<hr style='height:2px;color:maroon;opacity:1;margin-top:16px;margin-bottom:16px;width:100%'/>\"\n"
            + "+ \"<h6 style='color:maroon'>Resolution</h6>\"\n"
            + "+ \"<div style='height:80px;width:50%;margin-top:10px;margin-left:32px;margin-bottom:10px;padding:4px;border:2px solid maroon;border-radius:4px'>\" + d.Resolution + \"</div>\"\n"
            + "+ \"<div class='row'>\"\n"
            + "+ \"    <div class='col-1'></div>\"\n"
            + "+ \"    <div class='col-2'>\"\n"


            + "+ \"        <table style='border:2px solid maroon'>\"\n"
            + "+ \"            <tr><th style='text-align:right'>Fixed By:</th><td>\" + d.WhoFixed + \"</td></tr>\"\n"
            + "+ \"            <tr><th style='text-align:right'>Date Completed:</th><td>\" + d.DateComp + \"</td></tr>\"\n"
            + "+ \"            <tr><th style='text-align:right'>Work Order Nmbr:</th><td>\" + d.WorkOrderNmbr + \"</td></tr>\"\n"
            + "+ \"            <tr><th style='text-align:right'>Maint Task Code:</th><td>\" + d.MaintTaskCode + \"</td></tr>\"\n"
            + "+ \"            <tr><th style='text-align:right'>Inspector 1:</th><td>\" + d.FirstInspector + \"</td></tr>\"\n"
            + "+ \"            <tr><th style='text-align:right'>Inspector 2:</th><td>\" + d.SecondInspector + \"</td></tr>\"\n"
            + "+ \"        </table>\"\n"
            //+ "+ \"        <ul style='border:2px solid maroon;'>\"\n"
            //+ "+ \"            <li><span style='text-align:right'>Fixed By:</span><span>\" + d.WhoFixed + \"</span></li><br/>\"\n"
            //+ "+ \"            <li><span style='text-align:right'>Date Completed:</span><span>\" + d.DateComp + \"</span></li>\"\n"
            //+ "+ \"            <li><span style='text-align:right'>Work Order Nmbr:</span><span>\" + d.WorkOrderNmbr + \"</span></li>\"\n"
            //+ "+ \"            <li><span style='text-align:right'>Maint Task Code:</span><span>\" + d.MaintTaskCode + \"</span></li>\"\n"
            //+ "+ \"            <li><span style='text-align:right'>Inspector 1:</span><span>\" + d.FirstInspector + \"</span></li>\"\n"
            //+ "+ \"            <li><span style='text-align:right'>Inspector 2:</span><span>\" + d.SecondInspector + \"</span></li>\"\n"
            //+ "+ \"        </ul>\"\n"
            + "+ \"    </div>\"\n"
            + "+ \"    <div class='col-2'>\"\n"
            + "+ \"        <table style='border:2px solid maroon'>\"\n"
            + "+ \"            <tr style='height:12px'>\"\n"
            + "+ \"                <th>Part Nmbr</th><th>Whse</th><th>Serial Nmbr</th>\"\n"
            + "+ \"            </tr>\"\n"
            + "+ \"            <tr style='height:12px'>\"\n"
            + "+ \"                <td>\" + d.PartNumber01 + \"</td><td>\" + d.Warehouse01 + \"</td><td>\" + d.SerialNumber01 + \"</td>\"\n"
            + "+ \"            </tr>\"\n"
            + "+ \"            <tr style='height:12px'>\"\n"
            + "+ \"                <td>\" + d.PartNumber02 + \"</td><td>\" + d.Warehouse02 + \"</td><td>\" + d.SerialNumber02 + \"</td>\"\n"
            + "+ \"            </tr>\"\n"
            + "+ \"            <tr style='height:12px'>\"\n"
            + "+ \"                <td>\" + d.PartNumber03 + \"</td><td>\" + d.Warehouse03 + \"</td><td>\" + d.SerialNumber03 + \"</td>\"\n"
            + "+ \"            </tr>\"\n"
            + "+ \"            <tr style='height:12px'>\"\n"
            + "+ \"                <td>\" + d.PartNumber04 + \"</td><td>\" + d.Warehouse04 + \"</td><td>\" + d.SerialNumber04 + \"</td>\"\n"
            + "+ \"            </tr>\"\n"
            + "+ \"            <tr style='height:12px'>\"\n"
            + "+ \"                <td>\" + d.PartNumber05 + \"</td><td>\" + d.Warehouse05 + \"</td><td>\" + d.SerialNumber05 + \"</td>\"\n"
            + "+ \"            </tr>\"\n"
            + "+ \"        </table>\"\n"
            + "+ \"    </div>\"\n"
            + "+ \"</div>\"\n"
            ;

        public IActionResult Squawks()
        {
            var classList = _context.SquawkMasters.ToList();


            return (new GenericTableController()).GenericTableGenerator(
                squawksMasterDisplayFieldList
                , "Squawks"
                , classList.Select(e => (object)e).ToList()
                , squawkMasterChildRows
                , squawkChildFieldFormatter
                );
        }


        //List<FieldSpec> melEquipComplDisplayFieldList = new List<FieldSpec>()
        //{
        //    new FieldSpec("DateDispDuDef", "Due<br/>Date", "DateDispDuDef", "center", 80, "date"),
        //    new FieldSpec("SquawkNumber", "Squawk<br/>Number", "SquawkNumber", "center", 120),
        //    new FieldSpec("TypeCode", "Type<br/>Code", "TypeCode", "center", 120),
        //    new FieldSpec("TailNmbr", "Tail<br/>Nmbr", "TailNmbr", "center", 120),
        //    new FieldSpec("AircraftType", "Acft<br/>Type", "AircraftType", "center", 80),
        //    new FieldSpec("AtaChapCode", "Ata<br/>Chap<br/>Code", "AtaChapCode", "center", 80),
        //    new FieldSpec("MinEquipList", "MEL<br/>Type", "MinEquipList", "center", 80)
        //};

        
        List<FieldSpec> melEquipComplRprtDsplyFieldList = new List<FieldSpec>()
        {
            new FieldSpec("SquawkNumber", "Squawk Nbr", "SquawkNumber", "right", 64),
            // Ref # ??
            new FieldSpec("TailNmbr", "Tail Nmbr", "TailNmbr", "center", 64),
            new FieldSpec("AircraftType", "Acft Type", "AircraftType", "center", 64),
            new FieldSpec("TypeCode", "Type", "TypeCode", "center", 40),
            new FieldSpec("AtaChapCode", "ATA of Squawk", "AtaChapCode", "center", 50),
            new FieldSpec("ReportedBy", "Reported By", "ReportedBy", "right", 64),
            new FieldSpec("DateReceived", "Date Reported", "DateReceived", "center", 80, "date"),
            new FieldSpec("DateDispDuDef", "Date Due", "DateDispDuDef", "center", 80, "date"),
            new FieldSpec("DateComp", "Date Fixed", "DateComp", "center", 80, "date"), // Is this date fixed?
            new FieldSpec("FlightLogNmbr", "Flight Log Nmbr", "FlightLogNmbr", "center", 80),
            new FieldSpec("ItemNmbr", "Item Nbr", "ItemNmbr", "center", 80),
            new FieldSpec("Flight", "Flt Nbr", "Flight", "center", 60),
            new FieldSpec("WorkOrderNmbr", "Work Order", "WorkOrderNmbr", "center", 60),
            new FieldSpec("EngPositionNmbr", "Eng Pos", "EngPositionNmbr", "center", 60),
            new FieldSpec("DmiType", "DMI Type", "DmiType", "center", 60),
            // Cntr??
            new FieldSpec("AirframeAtSqwk", "A/F At Rprt", "AirframeAtSqwk", "center", 60, "fixed"),
            new FieldSpec("AFWhenDone", "A/F After", "AFWhenDone", "center", 60, "fixed"),
        };

        public IActionResult MELCmplDue()
        {

            var classList = (from s in _context.SquawkMasters
                             join a in _context.AcMasters
                             on s.TailNmbr equals a.TailNmbr
                             where s.MinEquipList != null
                             select new {
                                 s.PkRecordId
                                ,s.SquawkNumber
                                ,s.TailNmbr
                                ,s.TypeCode
                                ,s.AtaChapAndSub
                                ,s.ReportedBy
                                ,s.DateReceived
                                ,s.DateDeferred
                                ,s.DateComp
                                ,s.FlightLogNmbr
                                ,s.ItemNmbr
                                ,s.Flight
                                ,s.WorkOrderNmbr
                                ,s.EngPositionNmbr
                                ,s.DmiType
                                ,s.AirframeAtSqwk
                                ,s.AFWhenDone
                                ,a.AircraftType
                             }).ToList();


            return (new GenericTableController()).GenericTableGenerator(melEquipComplRprtDsplyFieldList, "MEL Compliance Due", classList.Select(e => (object)e).ToList());

        }

        //public IActionResult MELCmplDueFull()
        //{

        //    List<SquawkMaster> classList = _context.SquawkMasters.Where(s=>s.MinEquipList != null).ToList();

        //    return (new GenericTableController()).GenericTableGenerator(
        //        squawksMasterDisplayFieldList
        //        , "MEL Compliance Due"
        //        , classList.Select(e => (object)e).ToList()
        //        , "SquawksMasterClass"
        //        , "squawks_master");
        //}


        List<FieldSpec> dmiDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("DateDispDuDef", "Due Date", "DateDispDuDef", "center", 80, "date"),
            new FieldSpec("Status", "Open/Closed", "Status", "center", 120),
            new FieldSpec("TailNmbr", "Tail Nmbr", "TailNmbr", "center", 120),
            new FieldSpec("AircraftType", "Acft Type", "AircraftType", "center", 80),
            new FieldSpec("AtaChapCode", "Ata Chap Code", "AtaChapCode", "center", 64),
             new FieldSpec("City", "City", "City", "center", 64),
            new FieldSpec("TypeCode", "Type Code", "TypeCode", "center", 64),
            new FieldSpec("PartNumbers", "Part Numbers", "PartNumbers", "left", 120),
            new FieldSpec("SerialNumbers", "Serial Numbers", "SerialNumbers", "left", 120),
            new FieldSpec("WhoFixed", "Fixed By", "WhoFixed", "center", 40),
            new FieldSpec("FirstInspector", "Inspected By", "FirstInspector", "center", 60),
            new FieldSpec("EtopsSignificant", "Etops Signif", "EtopsSignificant", "center", 40, "bool"),
            new FieldSpec("EtopsConfirmed", "Etops Conf", "EtopsConfirmed", "center", 40, "bool"),
            new FieldSpec("EtopsConfirmedBy", "Etops Conf By", "EtopsConfirmedBy", "right", 60),
            new FieldSpec("EtopsVerified", "Etops Verified", "EtopsVerified", "center", 40, "bool"),
            new FieldSpec("EtopsVerifiedBy", "Etops Verified By", "EtopsVerifiedBy", "right", 60),
            new FieldSpec("CatIiiSignif", "Cat III Signif", "CatIiiSignif", "center", 40, "bool"),
            new FieldSpec("CatIiiVerified", "Cat III Verified", "CatIiiVerified", "center", 40, "bool"),
            new FieldSpec("Approach", "Aprch", "Approach", "center", 40, "bool"),
            new FieldSpec("Landing", "Land", "Landing", "center", 40, "bool"),
            new FieldSpec("EngineShutDown", "Eng Shut Down", "EngineShutDown", "center", 40, "bool"),
            new FieldSpec("DelayYN", "Delay", "DelayYN", "center", 40, "bool"),
            new FieldSpec("DelayMinutes", "Delay Minutes", "DelayMinutes", "right", 50),
            new FieldSpec("CancellationYN", "Cancel", "CancellationYN", "center", 40, "bool"),
            new FieldSpec("Description", "Description", "Description", "left", 240),
            new FieldSpec("Resolution", "Resolution", "Resolution", "left", 240),

        };


        public IActionResult DMIRprt()
        {

            var classList = (from s in _context.SquawkMasters
                             join a in _context.AcMasters
                             on s.TailNmbr equals a.TailNmbr
                             where s.DmiYN
                           
                             select new {
                                 s.PkRecordId
                                ,s.DateDeferred
                                ,s.TailNmbr
                                ,s.AtaChapAndSub
                                ,s.City
                                ,s.TypeCode
                                ,s.PartNumber01
                                ,s.SerialNumber01
                                ,s.WhoFixed
                                ,s.FirstInspector
                                ,s.EtopsSignificant
                                ,s.EtopsConfirmed
                                ,s.EtopsConfirmedBy
                                ,s.EtopsVerified
                                ,s.EtopsVerifiedBy
                                ,s.CatIiiSignif
                                ,s.CatIiiVerified
                                ,s.Approach
                                ,s.Landing
                                ,s.EngineShutDown
                                ,s.DelayYN
                                ,s.DelayMinutes
                                ,s.CancellationYN
                                ,s.Description
                                ,s.Resolution
                                 , Status = (s.DateComp != null) ? "Closed" : "Open"
                                 ,a.AircraftType
                             }).ToList();


            return (new GenericTableController()).GenericTableGenerator(dmiDisplayFieldList, "DMI Report", classList.Select(e => (object)e).ToList());

        }


        //public IActionResult DMIRprtFull()
        //{

        //    List<SquawkMaster> classList = _context.SquawkMasters.Where(s => s.DmiYN == true).ToList();

        //    return (new GenericTableController()).GenericTableGenerator(
        //        squawksMasterDisplayFieldList
        //        , "DMI Report"
        //        , classList.Select(e => (object)e).ToList()
        //        , "SquawksMasterClass"
        //        , "squawks_master");

        //}

        List<FieldSpec> MechSvcInterruptDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("SquawkNumber", "Squawk Nbr", "SquawkNumber", "center", 80),
            new FieldSpec("DateReceived", "Date", "DateReceived", "center", 80, "date"),
            new FieldSpec("TailNmbr", "Tail Nmbr", "TailNmbr", "center", 120),
            new FieldSpec("AircraftType", "Acft Type", "AircraftType", "center", 80),
            new FieldSpec("AtaChapCode", "Ata Chap Code", "AtaChapCode", "center", 80),
            new FieldSpec("Flight", "Flight Nbr", "Flight", "center", 80),
            new FieldSpec("DelayYN", "Delay<br/>(Y/N)", "DelayYN", "center", 50, "bool"),
            new FieldSpec("CancellationYN", "Cancel<br/>(Y/N)", "CancellationYN", "center", 50, "bool"),
            new FieldSpec("ServiceDiffYN", "Svc<br/>Diff<br/>(Y/N)", "ServiceDiffYN", "center", 50, "bool"),
            new FieldSpec("DelayMinutes", "Delay Minutes", "DelayMinutes", "right", 80),
            new FieldSpec("Description", "Description", "Description", "left", 240),
            new FieldSpec("Resolution", "Resolution", "Resolution", "left", 240),
            new FieldSpec("DateComp", "Date Fixed", "DateComp", "center", 80, "date"), // Is this date fixed?
            new FieldSpec("DateDispDuDef", "Deferred To", "DateDispDuDef", "center", 80, "date") // Is this date delayed until?
        };


        public IActionResult MechSvcInterrupt()
        {
            var classList = (from s in _context.SquawkMasters
                             join a in _context.AcMasters
                             on s.TailNmbr equals a.TailNmbr
                             where s.DmiNumber != null
                             select new {   
                                 s.PkRecordId
                                 ,s.SquawkNumber
                                ,s.DateReceived
                                ,s.TailNmbr
                                ,s.AtaChapAndSub
                                ,s.Flight
                                ,s.DelayYN
                                ,s.CancellationYN
                                ,s.ServiceDiffYN
                                ,s.DelayMinutes
                                ,s.Description
                                ,s.Resolution
                                ,s.DateComp
                                ,s.DateDeferred
                                , a.AircraftType }).ToList();


            return (new GenericTableController()).GenericTableGenerator(MechSvcInterruptDisplayFieldList, "Squawks With Service Interruptions", classList.Select(e => (object)e).ToList());

        }

        //public IActionResult MechSvcInterrupt()
        //{
        //    List<SquawkMaster> classList = _context.SquawkMasters.Where(s => s.ServiceDiffYN == true).ToList();

        //    return (new GenericTableController()).GenericTableGenerator(
        //        MechSvcInterruptDisplayFieldList
        //        , "Squawks With Service Interruptions"
        //        , classList.Select(e => (object)e).ToList()
        //        , "SquawksMasterClass"
        //        , "squawks_master");
        //}

    }
}
