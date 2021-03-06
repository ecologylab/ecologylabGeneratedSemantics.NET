//
// WikipediaPageType.cs
// s.im.pl serialization
//
// Generated by MetaMetadataDotNetTranslator.
// Copyright 2013 Interface Ecology Lab. 
//


using Ecologylab.Collections;
using Ecologylab.Semantics.Generated.Library.WikipediaNS;
using Ecologylab.Semantics.MetaMetadataNS;
using Ecologylab.Semantics.MetadataNS;
using Ecologylab.Semantics.MetadataNS.Builtins;
using Ecologylab.Semantics.MetadataNS.Scalar;
using Simpl.Fundamental.Generic;
using Simpl.Fundamental.Net;
using Simpl.Serialization;
using Simpl.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Ecologylab.Semantics.Generated.Library.WikipediaNS 
{
	/// <summary>
	/// An article on wikipedia
	/// </summary>
	[SimplInherit]
	public class WikipediaPageType : CompoundDocument
	{
		[SimplComposite]
		[MmName("main_image")]
		private Image mainImage;

		/// <summary>
		/// (For compatibility.)
		/// </summary>
		[SimplScalar]
		private MetadataParsedURL mainImageSrc;

		[SimplCollection("section")]
		[MmName("sections")]
		private List<Section> sections;

		[SimplCollection("thumbinner")]
		[MmName("thumbinners")]
		private List<Image> thumbinners;

		[SimplCollection("category")]
		[MmName("categories")]
		private List<WikipediaCategoryType> categories;

		public WikipediaPageType()
		{ }

		public WikipediaPageType(MetaMetadataCompositeField mmd) : base(mmd) { }


		public Image MainImage
		{
			get{return mainImage;}
			set
			{
				if (this.mainImage != value)
				{
					this.mainImage = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataParsedURL MainImageSrc
		{
			get{return mainImageSrc;}
			set
			{
				if (this.mainImageSrc != value)
				{
					this.mainImageSrc = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public List<Section> Sections
		{
			get{return sections;}
			set
			{
				if (this.sections != value)
				{
					this.sections = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public List<Image> Thumbinners
		{
			get{return thumbinners;}
			set
			{
				if (this.thumbinners != value)
				{
					this.thumbinners = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public List<WikipediaCategoryType> Categories
		{
			get{return categories;}
			set
			{
				if (this.categories != value)
				{
					this.categories = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}
	}
}
