//
// Author.cs
// s.im.pl serialization
//
// Generated by MetaMetadataDotNetTranslator.
// Copyright 2012 Interface Ecology Lab. 
//


using Simpl.Fundamental.Generic;
using Simpl.Serialization;
using Simpl.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using ecologylab.collections;
using ecologylab.semantics.generated.library.creative_work;
using ecologylab.semantics.metadata;
using ecologylab.semantics.metadata.builtins;
using ecologylab.semantics.metadata.scalar;
using ecologylab.semantics.metametadata;

namespace ecologylab.semantics.generated.library.creative_work 
{
	/// <summary>
	/// An author of an article or creative work.
	/// </summary>
	[SimplInherit]
	public class Author<CW> : Document where CW : CreativeWork
	{
		[SimplScalar]
		private MetadataString affiliation;

		[SimplScalar]
		private MetadataString city;

		[SimplCollection("publication")]
		[MmName("publications")]
		private List<CreativeWork> publications;

		public Author()
		{ }

		public Author(MetaMetadataCompositeField mmd) : base(mmd) { }


		public MetadataString Affiliation
		{
			get{return affiliation;}
			set
			{
				if (this.affiliation != value)
				{
					this.affiliation = value;
					this.RaisePropertyChanged( () => this.Affiliation );
				}
			}
		}

		public MetadataString City
		{
			get{return city;}
			set
			{
				if (this.city != value)
				{
					this.city = value;
					this.RaisePropertyChanged( () => this.City );
				}
			}
		}

		public List<CreativeWork> Publications
		{
			get{return publications;}
			set
			{
				if (this.publications != value)
				{
					this.publications = value;
					this.RaisePropertyChanged( () => this.Publications );
				}
			}
		}
	}
}