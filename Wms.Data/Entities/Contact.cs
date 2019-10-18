using System;
using System.Collections.Generic;

namespace Wms.Data.Entities
{
    public partial class Contact
    {
        public Contact()
        {
            Address = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool CustomerType { get; set; }
        public bool ContactType { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string WorkPhone { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
