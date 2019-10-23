using System;
using System.Collections.Generic;

namespace Wms.Data.Entities
{
    public partial class CCustomer
    {
        public CCustomer()
        {
            CAddress = new HashSet<CAddress>();
            CContactPerson = new HashSet<CContactPerson>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short CustomerType { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string WorkPhone { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }
        public string Salutation { get; set; }

        public virtual ICollection<CAddress> CAddress { get; set; }
        public virtual ICollection<CContactPerson> CContactPerson { get; set; }
    }
}
