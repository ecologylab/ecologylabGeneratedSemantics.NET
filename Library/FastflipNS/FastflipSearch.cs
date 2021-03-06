//
// FastflipSearch.cs
// s.im.pl serialization
//
// Generated by MetaMetadataDotNetTranslator.
// Copyright 2013 Interface Ecology Lab. 
//


using Ecologylab.Collections;
using Ecologylab.Semantics.Generated.Library.FastflipNS;
using Ecologylab.Semantics.MetaMetadataNS;
using Ecologylab.Semantics.MetadataNS;
using Ecologylab.Semantics.MetadataNS.Builtins;
using Simpl.Fundamental.Generic;
using Simpl.Serialization;
using Simpl.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Ecologylab.Semantics.Generated.Library.FastflipNS 
{
	/// <summary>
	/// Fast Flip Search
	/// </summary>
	[SimplInherit]
	public class FastflipSearch : CompoundDocument
	{
		[SimplCollection("thumbnail")]
		[MmName("thumbnails")]
		private List<Thumbnail> thumbnails;

		public FastflipSearch()
		{ }

		public FastflipSearch(MetaMetadataCompositeField mmd) : base(mmd) { }


		public List<Thumbnail> Thumbnails
		{
			get{return thumbnails;}
			set
			{
				if (this.thumbnails != value)
				{
					this.thumbnails = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}
	}
}
