using System;

namespace ModelNew
{
	public class Rootobject
	{
		public Class1[] Property1 { get; set; }
	}

	public class Class1
	{
		public LEI LEI { get; set; }
		public Entity Entity { get; set; }
		public Registration Registration { get; set; }
	}

	public class LEI
	{
		public string i { get; set; }
	}

	public class Entity
	{
		public Legalname LegalName { get; set; }
		public Legaladdress LegalAddress { get; set; }
		public Headquartersaddress HeadquartersAddress { get; set; }
		public Registrationauthority RegistrationAuthority { get; set; }
		public Legaljurisdiction LegalJurisdiction { get; set; }
		public Legalform LegalForm { get; set; }
		public Entitystatus EntityStatus { get; set; }
	}

	public class Legalname
	{
		public string xmllang { get; set; }
		public string i { get; set; }
	}

	public class Legaladdress
	{
		public string xmllang { get; set; }
		public Firstaddressline FirstAddressLine { get; set; }
		public Additionaladdressline[] AdditionalAddressLine { get; set; }
		public City City { get; set; }
		public Region Region { get; set; }
		public Country Country { get; set; }
		public Postalcode PostalCode { get; set; }
	}

	public class Firstaddressline
	{
		public string i { get; set; }
	}

	public class City
	{
		public string i { get; set; }
	}

	public class Region
	{
		public string i { get; set; }
	}

	public class Country
	{
		public string i { get; set; }
	}

	public class Postalcode
	{
		public string i { get; set; }
	}

	public class Additionaladdressline
	{
		public string i { get; set; }
	}

	public class Headquartersaddress
	{
		public string xmllang { get; set; }
		public Firstaddressline1 FirstAddressLine { get; set; }
		public Additionaladdressline1[] AdditionalAddressLine { get; set; }
		public City1 City { get; set; }
		public Region1 Region { get; set; }
		public Country1 Country { get; set; }
		public Postalcode1 PostalCode { get; set; }
	}

	public class Firstaddressline1
	{
		public string i { get; set; }
	}

	public class City1
	{
		public string i { get; set; }
	}

	public class Region1
	{
		public string i { get; set; }
	}

	public class Country1
	{
		public string i { get; set; }
	}

	public class Postalcode1
	{
		public string i { get; set; }
	}

	public class Additionaladdressline1
	{
		public string i { get; set; }
	}

	public class Registrationauthority
	{
		public Registrationauthorityid RegistrationAuthorityID { get; set; }
		public Otherregistrationauthorityid OtherRegistrationAuthorityID { get; set; }
		public Registrationauthorityentityid RegistrationAuthorityEntityID { get; set; }
	}

	public class Registrationauthorityid
	{
		public string i { get; set; }
	}

	public class Otherregistrationauthorityid
	{
		public string i { get; set; }
	}

	public class Registrationauthorityentityid
	{
		public string i { get; set; }
	}

	public class Legaljurisdiction
	{
		public string i { get; set; }
	}

	public class Legalform
	{
		public Entitylegalformcode EntityLegalFormCode { get; set; }
		public Otherlegalform OtherLegalForm { get; set; }
	}

	public class Entitylegalformcode
	{
		public string i { get; set; }
	}

	public class Otherlegalform
	{
		public string i { get; set; }
	}

	public class Entitystatus
	{
		public string i { get; set; }
	}

	public class Registration
	{
		public Initialregistrationdate InitialRegistrationDate { get; set; }
		public Lastupdatedate LastUpdateDate { get; set; }
		public Registrationstatus RegistrationStatus { get; set; }
		public Nextrenewaldate NextRenewalDate { get; set; }
		public Managinglou ManagingLOU { get; set; }
		public Validationsources ValidationSources { get; set; }
		public Validationauthority ValidationAuthority { get; set; }
		public Othervalidationauthorities OtherValidationAuthorities { get; set; }
	}

	public class Initialregistrationdate
	{
		public DateTime i { get; set; }
	}

	public class Lastupdatedate
	{
		public DateTime i { get; set; }
	}

	public class Registrationstatus
	{
		public string i { get; set; }
	}

	public class Nextrenewaldate
	{
		public DateTime i { get; set; }
	}

	public class Managinglou
	{
		public string i { get; set; }
	}

	public class Validationsources
	{
		public string i { get; set; }
	}

	public class Validationauthority
	{
		public Validationauthorityid ValidationAuthorityID { get; set; }
	}

	public class Validationauthorityid
	{
		public string i { get; set; }
	}

	public class Othervalidationauthorities
	{
		public Othervalidationauthority OtherValidationAuthority { get; set; }
	}

	public class Othervalidationauthority
	{
		public Validationauthorityid1 ValidationAuthorityID { get; set; }
		public Validationauthorityentityid ValidationAuthorityEntityID { get; set; }
	}

	public class Validationauthorityid1
	{
		public string i { get; set; }
	}

	public class Validationauthorityentityid
	{
		public string i { get; set; }
	}
}