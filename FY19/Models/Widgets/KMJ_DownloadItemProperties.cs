using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using CMS.DocumentEngine;

namespace FY19.Models.Widgets
{
    public class KMJ_DownloadItemProperties : IWidgetProperties
    {
        /// <summary>
        /// Media library name.
        /// </summary>
        public const string MEDIA_LIBRARY_NAME = "FY19";


        /// <summary>
        /// Guid of background image.
        /// </summary>
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Label = "Image", Order = 0)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), MEDIA_LIBRARY_NAME)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.png;.jpg;.jpeg")]
        //[Required]
        public IList<MediaFilesSelectorItem> Image { get; set; }

        ///// <summary>
        ///// Image.
        ///// </summary>
        //public DocumentAttachment ImageAttachment { get; set; }

        ///// <summary>
        ///// Text to be displayed.
        ///// </summary>
        //public string Text { get; set; }


        ///// <summary>
        ///// Button text.
        ///// </summary>
        //public string ButtonText { get; set; }


        /// <summary>
        /// Target of button link.
        ///// </summary>
        //[EditingComponent(TextInputComponent.IDENTIFIER, Label = "Button Target", Order = 1)]
        //public string ButtonTarget { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Title", Order = 1)]
        [EditingComponentProperty(nameof(TextInputProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 200 characters")]
        public string Title { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Label = "Text 1", Order = 2)]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string ContentText { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "URL", Order = 3)]
        [EditingComponentProperty(nameof(TextInputProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url { get; set; }

        [EditingComponent(RadioButtonsComponent.IDENTIFIER, Label = "New Icon", Order = 4, DefaultValue = "hide")]
        [EditingComponentProperty(nameof(RadioButtonsProperties.DataSource), "display;Display\r\nhide;Hide")]
        public string NewIcon { get; set; }
    }
}