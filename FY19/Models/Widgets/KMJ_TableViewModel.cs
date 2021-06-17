using SeventyeightDigital.CKEditor4_Wysiwyg;

namespace FY19.Models.Widgets
{
    public class KMJ_TableViewModel : InlineEditorViewModel
    {
        public CKEditor4_WysiwygViewModel EditorModel { get; set; }
        public string Html { get; set; }
        public string Id { get; set; }
        public string Class { get; set; }
    }
}