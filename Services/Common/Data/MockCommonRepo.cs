using DotNetCoreWebApi.Services.Common.Models;
using System.Collections.Generic;

namespace DotNetCoreWebApi.Services.Common.Data  
{
    public class MockCommonRepo : ICommonRepo
    {
        public void CreateAddress(Address req)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAddress(Address req)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Address> GetAllAddresses()
        {
            var addresses = new List<Address> 
            {
                new Address { Id=0, Address1= "7690 Treelawn Dr", Address2= "Test Address 2", City="Independence", StateId=1, PostalCode = 44141 },
                new Address { Id=1, Address1= "5774 E Wallings Rd", Address2= "Test Address 2", City="Broadview Heights", StateId=1, PostalCode = 44147 }
            };

            return addresses;
        }

        public Address GetAddressById(int Id)
        {
            return new Address { Id=0, Address1= "7690 Treelawn Dr", Address2= "Test Address 2", City="Independence", StateId=1, PostalCode = 44141 };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAddress(Address req)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UsaState> GetAllUsaStates()
        {
            throw new System.NotImplementedException();
        }

        public UsaState GetUsaStateById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void CreateUsaState(UsaState req)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUsaState(UsaState req)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUsaState(UsaState req)
        {
            throw new System.NotImplementedException();
        }
    }
}