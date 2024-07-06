namespace SpectrumWeb.Controllers.ControllerCommon
{
    public class GenericTableGeneratorParms
    {
        public string? UpdaterURL { get; set; } = null;

        public List<FieldSpec> DisplayFieldList { get; set; } = null;

        public string? Title { get; set; } = null;

        public List<object> ClassList { get; set; } = new List<object>();

        public List<FieldSpec> ChildFieldList { get; set; } = new List<FieldSpec>();

        public string? ChildFieldFormatter { get; set; } = null;

        public string? DetailsUrl { get; set; } = null;

        public string? CustomForm { get; set; } = null;

        public string? Overlay { get; set; } = null;

        public string? InitSearchValue { get; set; } = null;

        public string? InitSearchTitle { get; set; } = null;

        public string? TableSetup {  get; set; } = null;
    }
}
