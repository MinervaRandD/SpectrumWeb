namespace SpectrumWeb.Controllers.ControllerCommon
{

    public static class ControllerCommon
    {
        public static string TwoPartCustomForm(List<FieldSpec> fieldList, List<FieldSpec> childFieldList)
        {
            string rtrnValue = "<div id='customForm' class='row'>\n";

            rtrnValue += "    <div class='col'>\n";

            foreach (FieldSpec fieldSpec in fieldList)
            {
                if (isChildRow(fieldSpec, childFieldList))
                {
                    continue;
                }

                rtrnValue += "         <editor-field name='" + fieldSpec.field + "'></editor-field>\n";
            }

            rtrnValue += "    </div>\n";

            rtrnValue += "    <div class='col'>\n";

            foreach (FieldSpec fieldSpec in childFieldList)
            {
                rtrnValue += "         <editor-field name='" + fieldSpec.field + "'";
                
                if (fieldSpec.fieldHeight != null)
                {
                    rtrnValue += " style='height:" + fieldSpec.fieldHeight.Value + "px'";
                }

                rtrnValue += "></editor-field>\n";
            }

            rtrnValue += "    </div>\n";

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

    }
}
