﻿using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FY19.Models.Widgets
{
    public class KMJ_HeadHTMLProperties : IWidgetProperties
    {
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Heading Text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        [Required]
        public string Heading_Text { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Id")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Id { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Class")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Class { get; set; }
    }
}