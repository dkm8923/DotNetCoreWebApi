namespace DotNetCoreWebApi.Services.Common.Models 
{
    public class Address
    {
        public int Id { get; set; }
        
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public int StateId { get; set; }

        public int PostalCode { get; set; }
    }
} 