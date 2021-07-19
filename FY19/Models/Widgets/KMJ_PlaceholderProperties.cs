﻿using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FY19.Models.Widgets
{
    public class KMJ_PlaceholderProperties : IWidgetProperties
    {
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Heading Text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string PlaceholderText { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Id")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        public string Id { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Class")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Class { get; set; }
    }
}