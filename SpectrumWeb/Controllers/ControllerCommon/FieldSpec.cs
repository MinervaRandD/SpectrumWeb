namespace SpectrumWeb.Controllers.ControllerCommon
{
    public class FieldSpec
    {
        public string label { get;set;}

        public string description { get;set;}   

        public string field { get;set;}

        public string? fieldJustify { get; set; } = null;

        public short? fieldWidth { get; set; } = null;

        public string? fieldType { get; set; } = "text";

        public short? fieldHeight { get; set; } = null;

        public FieldSpec(
            string label
            ,string description
            ,string field
            ,string? fieldJustify = null
            ,short? fieldWidth = null
            ,string? fieldType = "text"
            ,short? fieldHeight= null
            )
        {
            this.label = label;

            this.description = description; 

            this.field = field;

            this.fieldJustify = fieldJustify;

            this.fieldWidth = fieldWidth;

            this.fieldType = fieldType;

            this.fieldHeight = fieldHeight;
        } 
    }
}
