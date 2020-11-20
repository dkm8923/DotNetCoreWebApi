namespace DotNetCoreWebApi.Services.Common.Dtos 
{
    public class AddressReadDto
    {
        public int Id { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public int StateId { get; set; }

        public int PostalCode { get; set; }

    }
}