using Microsoft.Identity.Client.Kerberos;
using System.Text;

namespace SpectrumWeb.Controllers.ControllerCommon
{

    public static class ControllerCommon
    {
        public static string TwoPartCustomForm(List<FieldSpec> fieldList, List<FieldSpec> childFieldList)
        {
            //string rtrnValue = "<div id='customForm' class='row'>\n";
            string rtrnValue = "<div id='customForm'>\n";
            //rtrnValue += "    <div class='col'>\n";

            rtrnValue += "    <fieldset>\n";

            foreach (FieldSpec fieldSpec in fieldList)
            {
                if (isChildRow(fieldSpec, childFieldList))
                {
                    continue;
                }

                rtrnValue += "         <editor-field name='" + fieldSpec.field + "'></editor-field>\n";
            }

            // rtrnValue += "    </div>\n";

            rtrnValue += "    </fieldset>\n";

            rtrnValue += "    <fieldset>\n";

            foreach (FieldSpec fieldSpec in childFieldList)
            {
                rtrnValue += "         <editor-field name='" + fieldSpec.field + "' type='textarea' ";
                
                if (fieldSpec.fieldHeight != null)
                {
                    rtrnValue += " style='height:" + fieldSpec.fieldHeight.Value + "px'";
                }

                rtrnValue += "></editor-field>\n";
            }

            rtrnValue += "    </fieldset>\n";

            // rtrnValue += "    </div>\n";

            rtrnValue += "</div>";

            return rtrnValue;
        }


        public static bool isChildRow(FieldSpec fieldSpec, List<FieldSpec> childFieldList)
        {
            if (childFieldList is null)
            {
                return false;
            }

            return childFieldList.Any(x => x.field == fieldSpec.field);

        }

        public static string childFieldConstructor(List<string> inptHtmlLines)
        {
            string rtrnValu = "\\\"" + inptHtmlLines[0] + "\\\"\\n\"\n";

            for (int i = 1; i < inptHtmlLines.Count; i++)
            {
                rtrnValu += "\"+ \\\"" + inptHtmlLines[i].Replace("\"", "\\\"") + "\\\"\\n\"\n";
            }

            return rtrnValu;

        }

        public static string trFunc(string id, string type, string title, bool? bVal)
        {
            string value = string.Empty;

            if (bVal.HasValue)
            {
                value = bVal.Value.ToString();
            }

            return trFunc(id, type, title, value); 
        }

        public static string trFunc(string id, string type, string title, short? sVal)
        {
            string value = string.Empty;

            if (sVal.HasValue)
            {
                value = sVal.Value.ToString();
            }

            return trFunc(id, type, title, value);
        }

        public static string trFunc(string id, string type, string title, int? iVal)
        {
            string value = string.Empty;

            if (iVal.HasValue)
            {
                value = iVal.Value.ToString();
            }

            return trFunc(id, type, title, value);
        }

        public static string trFunc(string id, string type, string title, string value)
        {
            string rtrnValu = "<tr>\n";

            rtrnValu += "<td> <label for='" + id + "'>" + title + ": </label></td>\n";

            if (type == "bool")
            {
                string undefinedSelected = string.Empty;
                string yesSelected = string.Empty;
                string noSelected = string.Empty;

              
                if (string.IsNullOrWhiteSpace(value))
                {
                    undefinedSelected = "selected";
                }

                else
                {
                    switch (value.ToLower())
                    {
                        case "true" or "t" or "yes" or "y":
                            yesSelected = "selected";
                            break;
                        case "false" or "f" or "no" or "n":
                            noSelected = "selected";
                            break;
                        default:
                            undefinedSelected = "selected";
                            break;
                    }
                }

                rtrnValu += "<td>\n";
                rtrnValu += "    <select id='" + id + "' name='" + id + "'><\n";
                rtrnValu += "        <option value='U' " + undefinedSelected + "> &nbsp;</option>\n";
                rtrnValu += "        <option value='Y' " + yesSelected + ">Y</option>\n";
                rtrnValu += "        <option value='N' " + noSelected  + ">N</option>\n";
                rtrnValu += "    </select>\n";
                rtrnValu += "</td>\n";
            }

            else
            {
                rtrnValu += "<td> <input type='" + type + "' id='" + id + "' name='" + id + "' value='" + value + "' /></td>\n";
            }

            rtrnValu += "</tr>\n";

            return rtrnValu;
        }
    }
}
