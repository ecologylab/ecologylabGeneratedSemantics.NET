//
//  TempFieldValueHolder.cs
//  s.im.pl serialization
//
//  Generated by DotNetTranslator on 04/01/11.
//  Copyright 2011 Interface Ecology Lab. 
//

using System;
using System.Collections.Generic;
using ecologylab.attributes;
using ecologylab.semantics.metadata.scalar;
using ecologylab.semantics.metadata;

namespace ecologylab.semantics.generated.library.artwork 
{
	/// <summary>
	/// This is a generated code. DO NOT edit or modify it.
	/// @author MetadataCompiler
	/// </summary>
	[simpl_descriptor_classes(new Type[] { typeof(MetadataClassDescriptor), typeof(MetadataFieldDescriptor) })]
	[simpl_inherit]
	public class TempFieldValueHolder : Metadata
	{
		/// <summary>
		/// missing java doc comments or could not find the source file.
		/// </summary>
		[simpl_scalar]
		private MetadataString tempMedium;

		/// <summary>
		/// missing java doc comments or could not find the source file.
		/// </summary>
		[simpl_scalar]
		private MetadataString tempDimensions;

		public TempFieldValueHolder()
		{ }

		public MetadataString TempMedium
		{
			get{return tempMedium;}
			set{tempMedium = value;}
		}

		public MetadataString TempDimensions
		{
			get{return tempDimensions;}
			set{tempDimensions = value;}
		}
	}
}