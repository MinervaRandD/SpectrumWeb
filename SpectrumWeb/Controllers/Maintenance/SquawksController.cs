﻿using Microsoft.AspNetCore.Mvc;
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
            new FieldSpec("SquawkNumber", "Squawk<br/>Number", "SquawkNumber", "right", 64),
            new FieldSpec("TypeCode", "Type<br/>Code", "TypeCode", "center", 40),
            new FieldSpec("Description", "Description", "Description", "left", 240),
            new FieldSpec("TailNmbr", "Tail<br/>Nmbr", "TailNmbr", "center", 64),
            new FieldSpec("AtaChapCode", "Ata<br/>Chap<br/>Code", "AtaChapCode", "center", 50),
            new FieldSpec("DateReceived", "Date<br/>Received", "DateReceived", "center", 80, "date"),
            new FieldSpec("ReportedBy", "Report By", "ReportedBy", "right", 64),
            new FieldSpec("DateDispDuDef", "Date<br/>Reported", "DateDispDuDef", "center", 80, "date"),
            new FieldSpec("Flight", "Flight", "Flight", "center", 60),
            new FieldSpec("AcType", "A/C<br/>Type", "AcType", "center", 60),
            new FieldSpec("FlightLogNmbr", "Flight<br/>Log<br/>Nmbr", "FlightLogNmbr", "center", 80),
            new FieldSpec("City", "City", "City", "center", 60),
            new FieldSpec("MinEquipList", "Min<br/>Equip<br/>List", "MinEquipList", "center", 60),
            new FieldSpec("DmiYN", "DMI<br/>Item<br/>(Y/N)", "DmiYN", "center", 50, "bool"),
            new FieldSpec("DmiType", "DMI<br/>Type", "DmiType", "center", 60),
            new FieldSpec("DmiNumber", "DMI<br/>Nmbr", "DmiNumber", "right", 60),
            new FieldSpec("EngPositionNmbr", "Eng<br/>Posn<br/>Nmbr", "EngPositionNmbr", "right", 40),
            new FieldSpec("DelayYN", "Delay<br/>(Y/N)", "DelayYN", "center", 50, "bool"),
            new FieldSpec("DelayMinutes", "Delay<br/>Minutes", "DelayMinutes", "right", 80),
            new FieldSpec("CancellationYN", "Cancel<br/>(Y/N)", "CancellationYN", "center", 50, "bool"),
            new FieldSpec("ServiceDiffYN", "Svc<br/>Diff<br/>(Y/N)", "ServiceDiffYN", "center", 50, "bool"),
            new FieldSpec("EngineShutDown", "Engine<br/>Shut<br/>Down", "EngineShutDown", "center", 50, "bool"),
            new FieldSpec("Approach", "Aprch", "Approach", "center", 50, "bool"),
            new FieldSpec("Landing", "Land", "Landing", "center", 50, "bool"),
            new FieldSpec("CatIiiSignif", "Cat<br/>III<br/>Signif", "CatIiiSignif", "center", 50, "bool"),
            new FieldSpec("CatIiiVerified", "Cat<br/>III<br/>Verified", "CatIiiVerified", "center", 50, "bool"),
            new FieldSpec("EtopsSignificant", "Etops<br/>Signif", "EtopsSignificant", "center", 50, "bool"),
            new FieldSpec("EtopsConfirmed", "Etops<br/>Conf", "EtopsConfirmed", "center", 50, "bool"),
            new FieldSpec("EtopsConfirmedBy", "Etops<br/>Conf<br/>By", "EtopsConfirmedBy", "right", 60),
            new FieldSpec("EtopsVerified", "Etops<br/>Verified", "EtopsVerified", "center", 50, "bool"),
            new FieldSpec("EtopsVerifiedBy", "Etops<br/>Verified<br/>By", "EtopsVerifiedBy", "right", 60),
            new FieldSpec("Resolution", "Resolution", "Resolution", "left", 240)
        };


        public IActionResult Squawks()
        {
            
            List < SquawkMaster > classList = _context.SquawkMasters.ToList();

            return (new GenericTableController()).GenericTableGenerator(squawksMasterDisplayFieldList, "Squawks", classList.Select(e => (object)e).ToList());
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
                                ,s.AtaChapCode
                                ,s.ReportedBy
                                ,s.DateReceived
                                ,s.DateDispDuDef
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
                                ,s.DateDispDuDef
                                ,s.TailNmbr
                                ,s.AtaChapCode
                                ,s.City
                                ,s.TypeCode
                                ,s.PartNumbers
                                ,s.SerialNumbers
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
                                ,s.AtaChapCode
                                ,s.Flight
                                ,s.DelayYN
                                ,s.CancellationYN
                                ,s.ServiceDiffYN
                                ,s.DelayMinutes
                                ,s.Description
                                ,s.Resolution
                                ,s.DateComp
                                ,s.DateDispDuDef
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
