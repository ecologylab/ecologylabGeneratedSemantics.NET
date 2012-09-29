//
// Person.cs
// s.im.pl serialization
//
// Generated by MetaMetadataDotNetTranslator.
// Copyright 2012 Interface Ecology Lab. 
//


using Ecologylab.Collections;
using Ecologylab.Semantics.Generated.Library.GisNS;
using Ecologylab.Semantics.Generated.Library.PersonNS;
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

namespace Ecologylab.Semantics.Generated.Library.PersonNS 
{
	/// <summary>
	/// Abstract type for a person.
	/// </summary>
	[SimplInherit]
	public class Person : Document
	{
		/// <summary>
		/// A representative photo for the person.
		/// </summary>
		[SimplComposite]
		[MmName("photo")]
		private Image photo;

		[SimplComposite]
		[MmName("birth_detail")]
		private BirthDetail birthDetail;

		[SimplScalar]
		private MetadataString gender;

		[SimplScalar]
		private MetadataString nationality;

		[SimplComposite]
		[MmName("spouse")]
		private Person spouse;

		[SimplCollection("person")]
		[MmName("parents")]
		private List<Person> parents;

		[SimplCollection("person")]
		[MmName("children")]
		private List<Person> children;

		[SimplCollection("person")]
		[MmName("related_to")]
		private List<Person> relatedTo;

		[SimplComposite]
		[MmName("contact")]
		private ContactPoint contact;

		public Person()
		{ }

		public Person(MetaMetadataCompositeField mmd) : base(mmd) { }


		public Image Photo
		{
			get{return photo;}
			set
			{
				if (this.photo != value)
				{
					this.photo = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public BirthDetail BirthDetail
		{
			get{return birthDetail;}
			set
			{
				if (this.birthDetail != value)
				{
					this.birthDetail = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataString Gender
		{
			get{return gender;}
			set
			{
				if (this.gender != value)
				{
					this.gender = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public MetadataString Nationality
		{
			get{return nationality;}
			set
			{
				if (this.nationality != value)
				{
					this.nationality = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public Person Spouse
		{
			get{return spouse;}
			set
			{
				if (this.spouse != value)
				{
					this.spouse = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public List<Person> Parents
		{
			get{return parents;}
			set
			{
				if (this.parents != value)
				{
					this.parents = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public List<Person> Children
		{
			get{return children;}
			set
			{
				if (this.children != value)
				{
					this.children = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public List<Person> RelatedTo
		{
			get{return relatedTo;}
			set
			{
				if (this.relatedTo != value)
				{
					this.relatedTo = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}

		public ContactPoint Contact
		{
			get{return contact;}
			set
			{
				if (this.contact != value)
				{
					this.contact = value;
					// TODO we need to implement our property change notification mechanism.
				}
			}
		}
	}
}