using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Web;

namespace FY19.Models.PageTemplates
{
    public class PageTemplateProperties : IPageTemplateProperties
    {
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Page Title")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        public string PageTitle { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Path")]
        public string Path { get; set; }
    }
}
