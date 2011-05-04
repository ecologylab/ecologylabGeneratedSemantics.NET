//
//  MomaArtwork.cs
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
using ecologylab.semantics.metadata.builtins;

namespace ecologylab.semantics.generated.library.artwork 
{
	/// <summary>
	/// This is a generated code. DO NOT edit or modify it.
	/// @author MetadataCompiler
	/// </summary>
	[simpl_descriptor_classes(new Type[] { typeof(MetadataClassDescriptor), typeof(MetadataFieldDescriptor) })]
	[simpl_inherit]
	public class MomaArtwork : Artwork
	{
		/// <summary>
		/// missing java doc comments or could not find the source file.
		/// </summary>
		[simpl_scalar]
		private MetadataString status;

		/// <summary>
		/// missing java doc comments or could not find the source file.
		/// </summary>
		[simpl_composite]
		[mm_name("moma_deparment")]
		private Document momaDeparment;

		/// <summary>
		/// missing java doc comments or could not find the source file.
		/// </summary>
		[simpl_composite]
		[mm_name("moma_classification")]
		private Document momaClassification;

		/// <summary>
		/// missing java doc comments or could not find the source file.
		/// </summary>
		[simpl_scalar]
		private MetadataParsedURL permalink;

		/// <summary>
		/// missing java doc comments or could not find the source file.
		/// </summary>
		[simpl_scalar]
		private MetadataParsedURL databaseLink;

		/// <summary>
		/// missing java doc comments or could not find the source file.
		/// </summary>
		[simpl_scalar]
		private MetadataString momaId;

		/// <summary>
		/// missing java doc comments or could not find the source file.
		/// </summary>
		[simpl_scalar]
		private MetadataParsedURL imageUrl;

		/// <summary>
		/// missing java doc comments or could not find the source file.
		/// </summary>
		[simpl_composite]
		[mm_name("temp_field_value_holder")]
		private TempFieldValueHolder tempFieldValueHolder;

		public MomaArtwork()
		{ }

		public MetadataString Status
		{
			get{return status;}
			set{status = value;}
		}

		public Document MomaDeparment
		{
			get{return momaDeparment;}
			set{momaDeparment = value;}
		}

		public Document MomaClassification
		{
			get{return momaClassification;}
			set{momaClassification = value;}
		}

		public MetadataParsedURL Permalink
		{
			get{return permalink;}
			set{permalink = value;}
		}

		public MetadataParsedURL DatabaseLink
		{
			get{return databaseLink;}
			set{databaseLink = value;}
		}

		public MetadataString MomaId
		{
			get{return momaId;}
			set{momaId = value;}
		}

		public MetadataParsedURL ImageUrl
		{
			get{return imageUrl;}
			set{imageUrl = value;}
		}

		public TempFieldValueHolder TempFieldValueHolder
		{
			get{return tempFieldValueHolder;}
			set{tempFieldValueHolder = value;}
		}
	}
}