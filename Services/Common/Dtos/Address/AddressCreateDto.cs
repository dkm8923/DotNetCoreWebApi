namespace DotNetCoreWebApi.Services.Common.Dtos 
{
    public class AddressCreateDto
    {
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public int StateId { get; set; }

        public int PostalCode { get; set; }
    }
}