using System;
using System.Collections.Generic;

namespace Wms.Data.Entities
{
    public partial class Address
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
