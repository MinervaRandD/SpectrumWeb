using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SpectrumWeb.Controllers.ControllerCommon
{
    public class GenericTableController : Controller
    {

        [HttpPost]
        public string GenericUpdater(string action, string data)
        {
            return "success";
        }


        public IActionResult GenericTableGenerator(
            List<FieldSpec> displayFieldList
            , string title
            , List<object> classList
            , List<FieldSpec> childFieldList = null
            , string childFieldFormater = null
            , string customForm = null
            )
        {
            GenericTableGeneratorParms tblGenParms = new GenericTableGeneratorParms()
            {
                UpdaterURL = "/GenericTable/GenericUpdater",
                DisplayFieldList = displayFieldList,
                Title = title,
                ClassList = classList,
                ChildFieldList = childFieldList,
                ChildFieldFormatter = childFieldFormater,
                CustomForm = customForm
            };

            return GenericTableGenerator(tblGenParms);
                
        }

        public IActionResult GenericTableGenerator(GenericTableGeneratorParms tblGenParms)
        {
            ViewBag.Title = tblGenParms.Title;

            List<List<string>> classFullValueList = new List<List<string>>();

            List<List<string>> classDisplayValueListWithRecordId = new List<List<string>>();

            foreach (object instance in tblGenParms.ClassList)
            {
                string str = JsonConvert.SerializeObject(instance);

                var fieldsDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(str);

                classFullValueList.Add(fieldsDict.Values.ToList());

                List<string> displayFieldValueList = WebPageGenerator.generateTableFieldValueList(fieldsDict, tblGenParms.DisplayFieldList);

                classDisplayValueListWithRecordId.Add(displayFieldValueList);
            }

            string tableFields = WebPageGenerator.generateTableFields(tblGenParms.DisplayFieldList, tblGenParms.ChildFieldList);

            ViewBag.TableFields = tableFields;

            string tableColumns = WebPageGenerator.generateTableColumns(tblGenParms.DisplayFieldList, tblGenParms.ChildFieldList);

            ViewBag.TableColumns = tableColumns;

            string tableHeader = WebPageGenerator.generateTableHeader(tblGenParms.DisplayFieldList, tblGenParms.ChildFieldList);

            ViewBag.TableHeader = tableHeader;

            string tableFooter = WebPageGenerator.generateTableFooter(tblGenParms.DisplayFieldList, tblGenParms.ChildFieldList);

            ViewBag.TableFooter = tableFooter;

            string classTableBody = WebPageGenerator.generateTableBody(classDisplayValueListWithRecordId, tblGenParms.DisplayFieldList, tblGenParms.ChildFieldList);

            ViewBag.ClassTableBody = classTableBody;

            string childRows = WebPageGenerator.generateChildRows(tblGenParms.ChildFieldList);

            ViewBag.ChildRows = childRows;

            if (tblGenParms.CustomForm != null)
            {
                ViewBag.TemplateSpec = "template: '#customForm',";
                ViewBag.TemplateDiv = tblGenParms.CustomForm;
            }

            else
            {
                ViewBag.TemplateSpec = string.Empty;
                ViewBag.TemplateDiv = string.Empty;
            }

            ViewBag.ChildFieldFormatter = "''";

            if (!string.IsNullOrEmpty(tblGenParms.ChildFieldFormatter))
            {
                ViewBag.ChildFieldFormatter = tblGenParms.ChildFieldFormatter;
            }

            string columnDefs = WebPageGenerator.generateColumnDefs(tblGenParms.DisplayFieldList, tblGenParms.ChildFieldList);

            ViewBag.ColumnDefs = columnDefs;

            //if (childFieldList != null)
            //{
            //    ViewBag.ColumnDefs = " columnDefs: [ { \"width\": \"16px\", \"targets\": 0 } ],";
            //}

            //else
            //{
            //    ViewBag.ColumnDefs = "";
            //}
            //string classMapInitializer = WebPageGenerator.generateClassMapInitializer(classFullValueList, className);

            //ViewBag.ClassMapInitializer = classMapInitializer;

            int? totalTableWidth = WebPageGenerator.generateTableWidth(tblGenParms.DisplayFieldList, tblGenParms.ChildFieldList);

            if (totalTableWidth != null)
            {
                ViewBag.TableWidth = "width:" + totalTableWidth.Value.ToString() + "px;";
            }

            else
            {
                ViewBag.TableWidth = string.Empty;
            }

            string detailsUrlStr = "null";

            if (tblGenParms.DetailsUrl != null)
            {

                detailsUrlStr = "'" + tblGenParms.DetailsUrl + "'";
            }

            ViewBag.DetailsUrl = detailsUrlStr;

            if (tblGenParms.Overlay != null)
            {
                ViewBag.Overlay = tblGenParms.Overlay;
            }

            else
            {
                ViewBag.Overlay = "''";

            }

            ViewBag.InitSearchTitle = tblGenParms.InitSearchTitle;

            ViewBag.InitSearchValue = tblGenParms.InitSearchValue;

            ViewBag.TableSetup = tblGenParms.TableSetup;

            return View("~/Views/Maintenance/GenericTable.cshtml");
        }
    }
}
