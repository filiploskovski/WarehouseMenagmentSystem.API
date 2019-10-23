using System;
using System.Collections.Generic;

namespace Wms.Data.Entities
{
    public partial class CContactPerson
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string WorkPhone { get; set; }
        public string Mobile { get; set; }
        public string Salutation { get; set; }

        public virtual CCustomer Customer { get; set; }
    }
}
