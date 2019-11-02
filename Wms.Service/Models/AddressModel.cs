namespace Wms.Service.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public short? AddressType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
    }
}