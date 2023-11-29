using System.Runtime.InteropServices.ComTypes;

namespace SpectrumWeb.Controllers.ControllerCommon
{
    public static class WebPageGenerator
    {
      

        public static string generateTableFields(List<FieldSpec> fieldList, List<FieldSpec> childRowList = null)
        {
            string rtrnValue = string.Join(",\n", fieldList.Where(f=>(!string.IsNullOrEmpty(f.field))&& !isChildRow(f,childRowList)).Select(f => "{ label: '" + f.description + "', name: '" + f.label + "' }"));
           
            return rtrnValue;
        }

        public static string generateTableColumns(List<FieldSpec> fieldList, List<FieldSpec> childRowList = null)
        {

            string rtrnValue = string.Empty;
               // "{ className: 'dt-control', orderable: false,data: null, defaultContent: '' },";

            if (childRowList != null)
            {
                rtrnValue += "{\r\n            className: 'dt-control',\r\n            orderable: false,\r\n            data: null,\r\n            defaultContent: ''\r\n        },";
            }

            rtrnValue += string.Join(",\n", fieldList.Where(f => !isChildRow(f, childRowList)).Select(f=>"{ data: '" + f.label + "' }"));

            return rtrnValue;
        }

        public static string generateTableHeader(List<FieldSpec> fieldList, List<FieldSpec> childFieldList = null)
        {
            string rtrnValue = string.Empty;

            if (childFieldList != null)
            {
                rtrnValue += "<th></th>\n";
            }

            foreach (FieldSpec fieldSpec in fieldList)
            {
                if (isChildRow(fieldSpec, childFieldList))
                {
                    continue;
                }

                string styleStr = "'text-align:center;";

                if (fieldSpec.fieldWidth.HasValue)
                {
                    styleStr += "width:" + fieldSpec.fieldWidth.Value.ToString() + "px;";
                }

                styleStr += "'";

                rtrnValue += "<th style=" + styleStr + ">" + fieldSpec.description + "</th>\n";
            }

            return rtrnValue;
        }

        public static string generateTableFooter(List<FieldSpec> fieldList, List<FieldSpec> childFieldList = null)
        {
            string rtrnValue = string.Empty;

            if (childFieldList != null)
            {
                rtrnValue += "<th></th>\n";
            }

            foreach (FieldSpec fieldSpec in fieldList)
            {
                if (isChildRow(fieldSpec, childFieldList))
                {
                    continue;
                }

                rtrnValue += "<th id='" + fieldSpec.label + "Footer'>" + fieldSpec.description + "</th>\n";
            }

            return rtrnValue;
        }


        public static string generateTableBody(List<List<string>> classDisplayValueListWithRecordId, List<FieldSpec> fieldSpecList, List<FieldSpec> childFieldList = null)
        {
            string rtrnValue = string.Empty;
            List<int> ilist = new List<int>();

            foreach (List<string> fieldValueList in classDisplayValueListWithRecordId)
            {
                rtrnValue += "<tr id='" + fieldValueList[0] + "'>\n"; // item 0 is the record id.

                if (childFieldList != null)
                {
                    rtrnValue += "<td></td>\n";
                }

                for (int i = 1; i < fieldValueList.Count; i++)
                {
                    //if (isChildRow(fieldSpecList[i], childFieldList))
                    //{
                    //    continue;
                    //}

                    string? fieldJustify = fieldSpecList[i - 1].fieldJustify;

                    if (fieldJustify != null)
                    {
                        rtrnValue += "    <td style='text-align:" + fieldJustify + ";'>" + fieldValueList[i] + "</td>\n";
                    }

                    else
                    {
                        rtrnValue += "    <td>" + fieldValueList[i] + "</td>\n";
                    }
                }

                rtrnValue += "</tr>\n";
            }
           
            return rtrnValue;
        }

        public static string generateTableBodyBuilder(List<FieldSpec> fieldList,  string keyField = "PkRecordId", List<FieldSpec> childFieldList = null)
        {
            string rtrnValue = "var tableBodyHtml = '';\n\n";

            rtrnValue += "classMap.forEach(function(classInstance) {\n";

            rtrnValue += "    " + "tableBodyHtml += \"<tr id='classInstance." + keyField + "'>\\n\\n\";\n\n";

            if (childFieldList != null)
            {
                rtrnValue += "    tableBodyHtml += \"    \" + \"<td></td>\"" + " + \"\\n\";\n";
            }

            foreach (var fieldSpec in fieldList)
            {
                if (isChildRow(fieldSpec,childFieldList))
                {
                    continue;
                }

                rtrnValue += "    tableBodyHtml += \"    \" + \"" + tableRow(fieldSpec) + " + \"\\n\";\n";
            }

            rtrnValue += "    " + "    tableBodyHtml += \"</tr>\\n\\n\";\n\n";

            rtrnValue += "   });\n\n";

            rtrnValue += "document.getElementById('classTableBody').innerHTML = tableBodyHtml;";

            return rtrnValue;
        }

        internal static List<string> generateTableFieldValueList(Dictionary<string, string> fieldsDict, List<FieldSpec> displayFieldList)
        {
            List<string> rtrnValue = new List<string>();

            string field = fieldsDict["PkRecordId"];


            rtrnValue.Add(field);

            foreach (FieldSpec fieldSpec in displayFieldList)
            {
                if (!fieldsDict.ContainsKey(fieldSpec.field))
                {
                    // This will happen if the field is a child row

                    continue;
                }

                field = fieldsDict[fieldSpec.field];


                if (fieldSpec.fieldType == "date")
                {
                    if (!string.IsNullOrEmpty(field))
                    {
                        field = field.Substring(0, 10);
                    }
                }

                else if (fieldSpec.fieldType == "bool")
                {
                    if (field == "true")
                    {
                        field = "Y";
                    }

                    else if (field == "false")
                    {
                        field = "N";
                    }
                }

                else if (fieldSpec.fieldType == "fixed")
                {
                    int dotIndx = field.LastIndexOf('.');

                    if (dotIndx == 0)
                    {
                        field = "0";
                    }

                    else if (dotIndx > 0)
                    {
                        field = field.Substring(0, dotIndx);
                    }
                }

                rtrnValue.Add(field);
            }

            return rtrnValue;
        }

        internal static string generateChildRows(List<FieldSpec> childFieldList)
        {
            string rtrnValue = string.Empty;

            if (childFieldList is null)
            {
                return rtrnValue;
            }

            rtrnValue += "<dl>\n";

            foreach (FieldSpec childField in childFieldList)
            {
                rtrnValue += "<dt>" + childField.description + ":</dt><dd>d." + childField.field + "</dd>\n";
            }

            rtrnValue += "</dl>";

            return rtrnValue;
        }

        private static string tableRow(FieldSpec fieldSpec)
        {

            string? justify = fieldSpec.fieldJustify;

            if (string.IsNullOrEmpty(justify))
            {
                justify = "left";
            }

            string styleStr = "'text-align:" + justify + ";padding-left:2px;padding-right:2px;'";


            string rtrnValue = "<td style=" + styleStr + ">\" + classInstance." + fieldSpec.label + " + \"</td>\"";

            return rtrnValue;
        }

        internal static string generateClassMapInitializer(List<List<string>> classValueList, string className, string key = "PkRecordId")
        {
            string rtrnValue = "classMap.clear();\n\nvar classInstance;\n\n";

            foreach (List<string> fieldList in classValueList)
            {
                rtrnValue += "classInstance = new " + className + "(";

                rtrnValue += string.Join(",", fieldList.Select(f=>"'" + f + "'"));

                rtrnValue += ");\n";

                rtrnValue += "classMap.set(classInstance." + key + ", classInstance);\n";
            }

            return rtrnValue;
        }

        internal static int? generateTableWidth(List<FieldSpec> displayFieldList)
        {
            int totalWidth = 0;

            foreach (FieldSpec field in displayFieldList)
            {
                if (field.fieldWidth == null)
                {
                    return null;
                }

                totalWidth += field.fieldWidth.Value;
            }

            return totalWidth;
        }


        private static bool isChildRow(FieldSpec fieldSpec, List<FieldSpec> childFieldList)
        {
            if (childFieldList is null)
            {
                return false;   
            }

            return childFieldList.Any(x => x.field == fieldSpec.field);

        }

    }
}
