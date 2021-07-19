using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FY19.Models.Widgets
{
    public class StaticTextModelProperties : IWidgetProperties
    {
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        public string Text { get; set; }
    }
}