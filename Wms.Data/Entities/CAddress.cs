using System;
using System.Collections.Generic;

namespace Wms.Data.Entities
{
    public partial class CAddress
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public short AddressType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }

        public virtual CCustomer Customer { get; set; }
    }
}
