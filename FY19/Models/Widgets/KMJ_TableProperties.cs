using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using SeventyeightDigital.CKEditor4_Wysiwyg;

namespace FY19.Models.Widgets
{
    public class KMJ_TableProperties : CKEditor4_WysiwygWidgetProperties, IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "Id")]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        public string Id { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Class")]
        public string Class { get; set; }
    }
}