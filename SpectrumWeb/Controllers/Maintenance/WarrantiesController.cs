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
            new FieldSpec("Details", "E<br/>d<br/>i<br/>t", "Details", "center", 20, "details")
           , new FieldSpec("Revision", "Rev", "Revision", "right", 20)
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

        static List<string> warrantiesChildDisplayFieldList = new List<string>()
        {
            "<style>"
            , "  table.childTable td, table.childTable th {"
            , "    border:solid;"
            , "    border-color:maroon;"
            , "    border-width:2px;"
            , "  }"
            , "  table.childTable th {"
            , "    background-color:#EFEFEF;"
            , "  }"
            , "</style>"
            , "<table class='childTable' style='width:100%'>"

            , "        <tr>"
            , "            <th style='width:256px'>Terms</th>"
            , "        </tr>"


            , "        <tr>"
            , "            <td>\" + d.Terms + \"</td>"
            , "        </tr>"


            , "        <tr>"
            , "            <th style='width:256px'>Notes</th>"
            , "        </tr>"


            , "        <tr>"
            , "            <td>\" + d.Notes + \"</td>"
            , "        </tr>"

            , "</table>"
        };

        static private string warrantiesChildFieldFormatter =
             "\"" + string.Join("\"\n + \"", warrantiesChildDisplayFieldList) + "\"";



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
                 "/GenericTable/GenericUpdater"
                , displayFieldList
                , title()
                , classList.Select(e => (object)e).ToList()
                , childFieldList
                , warrantiesChildFieldFormatter
                , "WarranteeDetailView"
                , null
                , overlay());
        }


        public IActionResult WarranteeDetailView(string id)
        {
            var data = context.GuaranteeWarranties.Where(g => g.PkRecordId == id).FirstOrDefault();
          
            ViewBag.Id = "'" + id + "'";
            ViewBag.Data = data;


            return View("~/Views/Maintenance/WarranteeDetailView.cshtml");
        }

        private string overlay()
        {
            string rtrnValu = string.Empty;

            string partNmbrFilter = generatePartNmbrFilter();

            rtrnValu = "<div id='overlay' style='display:block'>\n"
                     + "    <div style='height:256px'></div>\n"
                     + "    <div style='width:1024px;height:512px;margin:auto;background-color:rgba(253,253,253,0.95);border:solid;border-width:thick;border-color:maroon;border-radius:32px'>\n"
                     + "        <div style='display:inline-block;width:93%'><h4 style='text-align:center;color:maroon;margin:auto'>Select Guarantees and Warranties</h4></div>\n"
                     + "        <div style='display:inline-block;width:24px'><button onclick='hideFilter()' class='btn btn-outline-primary' style='border-color:maroon;border-width:2px;color:maroon;margin-top:2px;font:bolder'>X</button></div>\n"
                     + "        <div style='height:24px'></div>\n"
                     + "        <div style='margin:auto'>\n"
                     + partNmbrFilter
                     + "        </div>\n"
                     + "    </div>\n"
                     + "</div>\n";

            return rtrnValu;
        }

        private string generatePartNmbrFilter()
        {

            List<string?> partNmbrList = context.GuaranteeWarranties.Select(p => p.PartNumber).ToList();

            SortedDictionary<string, int> partNmbrDict = new SortedDictionary<string, int>();

            foreach (string?  partNmbr in partNmbrList)
            {
                if (string.IsNullOrEmpty(partNmbr))
                {
                    continue;
                }

                if (partNmbrDict.ContainsKey(partNmbr))
                {
                    partNmbrDict[partNmbr]++;
                }

                else
                {
                    partNmbrDict.Add(partNmbr, 1);
                }
            }

            string rtrnValu = generateSelectionTable("Part Nmbr", partNmbrDict, "ALL");

            return rtrnValu;

        }

        private string generateSelectionTable(string title, SortedDictionary<string, int> partNmbrDict, string defaultValu)
        {
            string rtrnValu = "            <table id=partNmbr>\n"
                            + "                <thead>\n"
                            + "                    <th>" + title + "</th>\n"
                            + "                    <th> Count </th>\n"
                            + "                </thead>\n"
                            + "                <tbody>\n";

            foreach (var kvp in partNmbrDict)
            {
                rtrnValu   += "                    <tr>\n";
                rtrnValu   += "                        <td>" + kvp.Key + "</td>\n";
                rtrnValu   += "                        <td>" + kvp.Value.ToString().PadLeft(4) + "</td>\n";
                rtrnValu   += "                    </tr>\n";
            }

            rtrnValu       += "                </tbody>\n";

            rtrnValu       += "            </table>\n";

            return rtrnValu;
        }

        private string title()
        {
            string rtrnValu = string.Empty;

            rtrnValu = "Guarantees and Warranties";

            return rtrnValu;
        }
    }
    
}
