using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SpectrumWeb.Controllers.Admin;

namespace SpectrumWeb.Controllers.Maintenance
{
    public class WarrantiesController : Controller
    {
       
        private readonly ArmsSpectrumDevelopmentContext context;

        public WarrantiesController(ArmsSpectrumDevelopmentContext context)
        {
            this.context = context;
        }


        private static List<FieldSpec> displayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("Revision", "Revision", "Revision", "right", 60)
            ,new FieldSpec("Number", "Number", "Number", "center", 120)
            ,new FieldSpec("PartNumber", "Part<br/>Number", "PartNumber", "center", 120)
            ,new FieldSpec("SerialNmbr", "Serial<br/>Number", "SerialNmbr", "center", 120)
            ,new FieldSpec("DateReceived", "Date<br/>Received", "DateReceived", "center", 80, "date")
            ,new FieldSpec("HoursGuaranteed", "Hours<br/>Guaranteed", "HoursGuaranteed", "right", 80, "#,##0.0")
            ,new FieldSpec("CyclesGuaranteed", "Cycles<br/>Guaranteed", "CyclesGuaranteed", "right", 80)
            ,new FieldSpec("WeeksGuaranteed", "Weeks<br/>Guaranteed", "WeeksGuaranteed", "right", 80)
            ,new FieldSpec("HoursAtInstall", "Hours At<br/>Install", "HoursAtInstall", "right", 80)
            ,new FieldSpec("CyclesAtInstall", "Cycles At<br/>Install", "CyclsAtInstall", "right", 80)
            ,new FieldSpec("WeeksAtInstall", "Weeks At<br/>Install", "WeeksAtInstall", "right", 80)
            ,new FieldSpec("Terms", "Terms<br/>Term", "Terms", "center",120)
            ,new FieldSpec("Notes", "Notes", "Notes", "left", 120)
            ,new FieldSpec("ExchangedSerNmbr", "Exchanged<br/>Serial<br/>Number","ExchangedSerNmbr", "center", 120)
            ,new FieldSpec("ControlTag", "Control<br/>Tag", "ControlTag", "center", 120)
            ,new FieldSpec("VendorNumber", "Vendor<br/>Number", "VendorNumber", "center", 120)
            ,new FieldSpec("AtaChap", "ATA<br/>Chap", "AtaChap", "center", 50)   
        };

        private static List<FieldSpec> childFieldList = new List<FieldSpec>()
        {
            new FieldSpec("Terms", "Terms", "Terms", "Left", 500, "text", 24)
            ,new FieldSpec("Notes", "Notes", "Notes", "Left", 500, "text", 128)
        };



        private string warrantiesChildFieldFormatter =
            "\"<style>\"\n"
            + "+ \"  table.childTable td, table.childTable th {\"\n"
            + "+ \"    border:solid;\"\n"
            + "+ \"    border-color:maroon;\"\n"
            + "+ \"    border-width:2px;\"\n"
            + "+ \"  }\"\n"
            + "+ \"  table.childTable th {\"\n"
            + "+ \"    background-color:#EFEFEF;\"\n"
            + "+ \"  }\"\n"
            + "+ \"</style>\"\n"
            + "+ \"<table class='childTable'>\"\n"
            + "+ \"    <thead>\"\n"
            + "+ \"        <tr>\"\n"
            + "+ \"            <th style='width:48px'>Terms</th><th style='width:80%'>Notes</th>\"\n"
            + "+ \"        </tr>\"\n"
            + "+ \"    </thead>\"\n"
            + "+ \"    <tbody>\"\n"
            + "+ \"        <tr>\"\n"
            + "+ \"            <td>\" + d.Terms + \"</td><td>\" + d.Notes + \"</td>\"\n"
            + "+ \"        </tr>\"\n"
            + "+ \"    </tbody>\"\n"
            + "+ \"</table>\"\n"
            ;

        private string customForm = ControllerCommon.ControllerCommon.TwoPartCustomForm(displayFieldList.GetRange(1, displayFieldList.Count-1), childFieldList);

        public IActionResult Warranties()
        {
            List<GuaranteeWarrantyBaseView> classList = context.GuaranteeWarrantyBaseViews.ToList();

            List<object> childRowField = new List<object>();

            foreach (GuaranteeWarrantyBaseView guaranteeWarranty in classList)
            {
                //List<object> fieldList = new List<object>();

                if (guaranteeWarranty.HoursGuaranteed.HasValue)
                {
                    guaranteeWarranty.HoursGuaranteed = Math.Round(guaranteeWarranty.HoursGuaranteed.Value, 1);
                }

                if (guaranteeWarranty.HoursAtInstall.HasValue)
                {
                    guaranteeWarranty.HoursAtInstall = Math.Round(guaranteeWarranty.HoursAtInstall.Value, 1);
                }
            }

            return (new GenericTableController()).GenericTableGenerator(
                displayFieldList
                , "Guarantees and Warranties"
                , classList.Select(e => (object)e).ToList()
                , childFieldList
                , warrantiesChildFieldFormatter);
        }
    }
    
}
