//
// DateInfo.cs
// s.im.pl serialization
//
// Generated by MetaMetadataDotNetTranslator.
// Copyright 2013 Interface Ecology Lab. 
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

namespace Ecologylab.Semantics.Generated.Library.DleseNS 
{
	[SimplInherit]
	public class DateInfo : Metadata
	{
		[SimplScalar]
		private MetadataDate created;

		[SimplScalar]
		private MetadataDate accessioned;

		public DateInfo()
		{ }

		public DateInfo(MetaMetadataCompositeField mmd) : base(mmd) { }


		public MetadataDate Created
		{
			get{return created;}
			set
			{
				if (this.created != value)
				{
					this.created = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataDate Accessioned
		{
			get{return accessioned;}
			set
			{
				if (this.accessioned != value)
				{
					this.accessioned = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}
	}
}
