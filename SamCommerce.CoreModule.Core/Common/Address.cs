using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCommerce.CoreModule.Core.Common
{
    public class Address
    {
        public AddressType AddressType { get; set; }
        public string? Name { get; set; }
        public string? Organization { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Zip { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? RegionId { get; set; }
        public string? RegionName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? OuterId { get; set; }
        public bool IsDefault { get; set; }
        public string? Description { get; set; }
    }
}
