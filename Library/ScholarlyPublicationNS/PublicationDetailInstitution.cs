//
// PublicationDetailInstitution.cs
// s.im.pl serialization
//
// Generated by MetaMetadataDotNetTranslator.
// Copyright 2012 Interface Ecology Lab. 
//


using Ecologylab.Collections;
using Ecologylab.Semantics.MetaMetadataNS;
using Ecologylab.Semantics.MetadataNS;
using Ecologylab.Semantics.MetadataNS.Builtins;
using Ecologylab.Semantics.MetadataNS.Scalar;
using Simpl.Fundamental.Generic;
using Simpl.Serialization;
using Simpl.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Ecologylab.Semantics.Generated.Library.ScholarlyPublicationNS 
{
	[SimplInherit]
	public class PublicationDetailInstitution : Metadata
	{
		[SimplScalar]
		private MetadataString publicationYears;

		[SimplScalar]
		private MetadataInteger publicationCount;

		[SimplScalar]
		private MetadataInteger citationCount;

		[SimplScalar]
		private MetadataInteger sixWeekDownloadCount;

		[SimplScalar]
		private MetadataInteger yearDownloadCount;

		[SimplScalar]
		private MetadataInteger downloadCount;

		[SimplScalar]
		private MetadataFloat downloadsPerArticle;

		[SimplScalar]
		private MetadataFloat citationsPerArticle;

		public PublicationDetailInstitution()
		{ }

		public PublicationDetailInstitution(MetaMetadataCompositeField mmd) : base(mmd) { }


		public MetadataString PublicationYears
		{
			get{return publicationYears;}
			set
			{
				if (this.publicationYears != value)
				{
					this.publicationYears = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataInteger PublicationCount
		{
			get{return publicationCount;}
			set
			{
				if (this.publicationCount != value)
				{
					this.publicationCount = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataInteger CitationCount
		{
			get{return citationCount;}
			set
			{
				if (this.citationCount != value)
				{
					this.citationCount = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataInteger SixWeekDownloadCount
		{
			get{return sixWeekDownloadCount;}
			set
			{
				if (this.sixWeekDownloadCount != value)
				{
					this.sixWeekDownloadCount = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataInteger YearDownloadCount
		{
			get{return yearDownloadCount;}
			set
			{
				if (this.yearDownloadCount != value)
				{
					this.yearDownloadCount = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataInteger DownloadCount
		{
			get{return downloadCount;}
			set
			{
				if (this.downloadCount != value)
				{
					this.downloadCount = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataFloat DownloadsPerArticle
		{
			get{return downloadsPerArticle;}
			set
			{
				if (this.downloadsPerArticle != value)
				{
					this.downloadsPerArticle = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataFloat CitationsPerArticle
		{
			get{return citationsPerArticle;}
			set
			{
				if (this.citationsPerArticle != value)
				{
					this.citationsPerArticle = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}
	}
}