//
// ResultInfo.cs
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
	public class ResultInfo : Metadata
	{
		[SimplScalar]
		private MetadataInteger offset;

		[SimplScalar]
		[SimplTag("numReturned")]
		private MetadataInteger returned;

		[SimplScalar]
		[SimplTag("totalNumRecordsInLibrary")]
		private MetadataInteger totalRecords;

		[SimplScalar]
		[SimplTag("totalNumResults")]
		private MetadataInteger totalResults;

		public ResultInfo()
		{ }

		public ResultInfo(MetaMetadataCompositeField mmd) : base(mmd) { }


		public MetadataInteger Offset
		{
			get{return offset;}
			set
			{
				if (this.offset != value)
				{
					this.offset = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataInteger Returned
		{
			get{return returned;}
			set
			{
				if (this.returned != value)
				{
					this.returned = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataInteger TotalRecords
		{
			get{return totalRecords;}
			set
			{
				if (this.totalRecords != value)
				{
					this.totalRecords = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataInteger TotalResults
		{
			get{return totalResults;}
			set
			{
				if (this.totalResults != value)
				{
					this.totalResults = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}
	}
}
