//
// AmazonProduct.cs
// s.im.pl serialization
//
// Generated by MetaMetadataDotNetTranslator on 10/26/11.
// Copyright 2011 Interface Ecology Lab. 
//


using Simpl.Fundamental.Generic;
using Simpl.Serialization;
using Simpl.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using ecologylab.collections;
using ecologylab.semantics.generated.library.products;
using ecologylab.semantics.metadata;
using ecologylab.semantics.metadata.builtins;
using ecologylab.semantics.metametadata;

namespace ecologylab.semantics.generated.library.products 
{
	[SimplInherit]
	public class AmazonProduct : Product
	{
		[SimplComposite]
		[MmName("department")]
		private Document department;

		[SimplComposite]
		[MmName("bestseller_list")]
		private BestsellerList bestsellerList;

		public AmazonProduct()
		{ }

		public Document Department
		{
			get{return department;}
			set{department = value;}
		}

		public BestsellerList BestsellerList
		{
			get{return bestsellerList;}
			set{bestsellerList = value;}
		}
	}
}