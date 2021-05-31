//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.KMJ_ITG;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(MasterPage.CLASS_NAME, typeof(MasterPage))]

namespace CMS.DocumentEngine.Types.KMJ_ITG
{
	/// <summary>
	/// Represents a content item of type MasterPage.
	/// </summary>
	public partial class MasterPage : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "KMJ_ITG.MasterPage";


		/// <summary>
		/// The instance of the class that provides extended API for working with MasterPage fields.
		/// </summary>
		private readonly MasterPageFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// MasterPageID.
		/// </summary>
		[DatabaseIDField]
		public int MasterPageID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("MasterPageID"), 0);
			}
			set
			{
				SetValue("MasterPageID", value);
			}
		}


		/// <summary>
		/// og:image.
		/// </summary>
		[DatabaseField]
		public string OgImage
		{
			get
			{
				return ValidationHelper.GetString(GetValue("OgImage"), @"");
			}
			set
			{
				SetValue("OgImage", value);
			}
		}


		/// <summary>
		/// Text.
		/// </summary>
		[DatabaseField]
		public string Text
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Text"), @"");
			}
			set
			{
				SetValue("Text", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with MasterPage fields.
		/// </summary>
		[RegisterProperty]
		public MasterPageFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with MasterPage fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class MasterPageFields : AbstractHierarchicalObject<MasterPageFields>
		{
			/// <summary>
			/// The content item of type MasterPage that is a target of the extended API.
			/// </summary>
			private readonly MasterPage mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="MasterPageFields" /> class with the specified content item of type MasterPage.
			/// </summary>
			/// <param name="instance">The content item of type MasterPage that is a target of the extended API.</param>
			public MasterPageFields(MasterPage instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// MasterPageID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.MasterPageID;
				}
				set
				{
					mInstance.MasterPageID = value;
				}
			}


			/// <summary>
			/// og:image.
			/// </summary>
			public string OgImage
			{
				get
				{
					return mInstance.OgImage;
				}
				set
				{
					mInstance.OgImage = value;
				}
			}


			/// <summary>
			/// Text.
			/// </summary>
			public string Text
			{
				get
				{
					return mInstance.Text;
				}
				set
				{
					mInstance.Text = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="MasterPage" /> class.
		/// </summary>
		public MasterPage() : base(CLASS_NAME)
		{
			mFields = new MasterPageFields(this);
		}

		#endregion
	}
}