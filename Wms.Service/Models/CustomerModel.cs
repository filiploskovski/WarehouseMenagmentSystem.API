using System;
using System.Collections.Generic;
using System.Text;

namespace Wms.Service.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool CustomerType { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string WorkPhone { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }
        public string Salutation { get; set; }
    }
}
