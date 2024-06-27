using Domain.Tax;
using System;

namespace Domain.Customers
{
    public partial class Customer : BaseEntity, ISoftDeletedEntity
    {
        public Customer()
        {
            CustomerGuid = Guid.NewGuid();
        }

        public Guid CustomerGuid { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Company { get; set; }

        public string StreetAddress { get; set; }

        public string StreetAddress2 { get; set; }

        public string ZipPostalCode { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public int CountryId { get; set; }

        public int StateProvinceId { get; set; }


        public string Fax { get; set; }

        public string VatNumber { get; set; }

        public int VatNumberStatusId { get; set; }

        public string TimeZoneId { get; set; }

        public string CustomCustomerAttributesXML { get; set; }

        public int? CurrencyId { get; set; }

        public int? LanguageId { get; set; }

        public int? TaxDisplayTypeId { get; set; }

        public string EmailToRevalidate { get; set; }

        public string AdminComment { get; set; }

        public bool IsTaxExempt { get; set; }

        public int AffiliateId { get; set; }

        public int VendorId { get; set; }

        public bool HasShoppingCartItems { get; set; }

        public bool RequireReLogin { get; set; }

        public int FailedLoginAttempts { get; set; }

        public DateTime? CannotLoginUntilDateUtc { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        public bool IsSystemAccount { get; set; }

        public string SystemName { get; set; }

        public string LastIpAddress { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime? LastLoginDateUtc { get; set; }

        public DateTime LastActivityDateUtc { get; set; }

        public int RegisteredInStoreId { get; set; }

        public int? BillingAddressId { get; set; }

        public int? ShippingAddressId { get; set; }

        #region Custom properties

        public VatNumberStatus VatNumberStatus
        {
            get => (VatNumberStatus)VatNumberStatusId;
            set => VatNumberStatusId = (int)value;
        }


        public TaxDisplayType? TaxDisplayType
        {
            get => TaxDisplayTypeId.HasValue ? (TaxDisplayType)TaxDisplayTypeId : null;
            set => TaxDisplayTypeId = value.HasValue ? (int)value : null;
        }

        #endregion
    }
}