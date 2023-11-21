using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;

namespace SpectrumWeb.Controllers.Maintenance
{
    public class M19ComponentRemovalsController : Controller
    {
        public IActionResult ComponentRemovalsGenerator(
            List<FieldSpec> displayFieldList
            , string title
            , List<object> classList
            , string className
            , string classDefnFileName)
        {
            ViewBag.Title = title;

            List<List<string>> classFullValueList = new List<List<string>>();

            List<List<string>> classDisplayValueListWithRecordId = new List<List<string>>();

            foreach (object instance in classList)
            {
                string str = Newtonsoft.Json.JsonConvert.SerializeObject(instance);

                var fieldsDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(str);

                classFullValueList.Add(fieldsDict.Values.ToList<string>());

                List<string> displayFieldValueList = WebPageGenerator.generateTableFieldValueList(fieldsDict, displayFieldList);

                classDisplayValueListWithRecordId.Add(displayFieldValueList);
            }

            string tableFields = WebPageGenerator.generateTableFields(displayFieldList);

            ViewBag.TableFields = tableFields;

            string tableColumns = WebPageGenerator.generateTableColumns(displayFieldList);

            ViewBag.TableColumns = tableColumns;

            string tableHeader = WebPageGenerator.generateTableHeader(displayFieldList);

            ViewBag.TableHeader = tableHeader;

            string tableFooter = WebPageGenerator.generateTableFooter(displayFieldList);

            ViewBag.TableFooter = tableFooter;

            string classTableBody = WebPageGenerator.generateTableBody(classDisplayValueListWithRecordId, displayFieldList);

            ViewBag.ClassTableBody = classTableBody;

            string tableBodyBuilder = WebPageGenerator.generateTableBodyBuilder(displayFieldList);

            ViewBag.TableBodyBuilder = tableBodyBuilder;

            string classMapInitializer = WebPageGenerator.generateClassMapInitializer(classFullValueList, className);

            ViewBag.ClassMapInitializer = classMapInitializer;

            int? totalTableWidth = WebPageGenerator.generateTableWidth(displayFieldList);

            if (totalTableWidth != null)
            {
                ViewBag.TableWidth = "width:" + totalTableWidth.Value.ToString() + "px;";
            }

            else
            {
                ViewBag.TableWidth = string.Empty;
            }

            ViewBag.ClassDefnScript = "<script type='text/javascript' language='javascript' src='/local/" + classDefnFileName + ".js'></script >";

            return View("~/Views/Maintenance/Maintenance/ReportGeneratorViews/M19ComponentRemovals.cshtml");
        }
    }
}
