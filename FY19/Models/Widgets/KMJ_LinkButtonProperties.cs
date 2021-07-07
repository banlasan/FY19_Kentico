using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FY19.Models.Widgets
{
    public class KMJ_LinkButtonProperties : IWidgetProperties
    {
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Text 1")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        [Required]
        public string TextContent { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "URL", DefaultValue = "https://")]
        [EditingComponentProperty(nameof(TextInputProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        [Required]
        public string Url { get; set; } 

        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 2, Label = "Opens in a new window")]
        [EditingComponentProperty(nameof(CheckBoxProperties.Name), "")]
        public bool Blank { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Id")]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Id { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 4, Label = "Class")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Class { get; set; }
    }
}