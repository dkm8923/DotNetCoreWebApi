using DotNetCoreWebApi.Services.Common.Models;
using System.Collections.Generic;

namespace DotNetCoreWebApi.Services.Common.Data  
{
    public interface ICommonRepo
    {
        bool SaveChanges();

        IEnumerable<Address> GetAllAddresses();
        Address GetAddressById(int Id);
        void CreateAddress(Address req);
        void UpdateAddress(Address req);
        void DeleteAddress(Address req);

        IEnumerable<UsaState> GetAllUsaStates();
        UsaState GetUsaStateById(int Id);
        void CreateUsaState(UsaState req);
        void UpdateUsaState(UsaState req);
        void DeleteUsaState(UsaState req);
    }
}