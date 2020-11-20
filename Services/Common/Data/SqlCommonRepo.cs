using System;
using System.Collections.Generic;
using System.Linq;
using DotNetCoreWebApi.Services.Common.Models;

namespace DotNetCoreWebApi.Services.Common.Data 
{
    public class SqlCommonRepo : ICommonRepo 
    {
        private readonly CommonDbContext _context;

        public SqlCommonRepo(CommonDbContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void CreateAddress(Address req)
        {
            if (req == null) 
            {
                throw new ArgumentNullException(nameof(req));
            }

            _context.Addresses.Add(req);
        }

        public IEnumerable<Address> GetAllAddresses()
        {
            return _context.Addresses.ToList();
        }

        public Address GetAddressById(int id)
        {
            return _context.Addresses.FirstOrDefault(p => p.Id == id);
        }

        public void UpdateAddress(Address req)
        {
            // throw new NotImplementedException();
        }

        public void DeleteAddress(Address req)
        {
            if (req == null) 
            {
                throw new ArgumentNullException(nameof(req));
            }

            _context.Addresses.Remove(req);
        }

        public IEnumerable<UsaState> GetAllUsaStates()
        {
            return _context.UsaStates.ToList();
        }

        public UsaState GetUsaStateById(int id)
        {
            return _context.UsaStates.FirstOrDefault(p => p.Id == id);
        }

        public void CreateUsaState(UsaState req)
        {
            if (req == null)
            {
                throw new ArgumentNullException(nameof(req));
            }

            _context.UsaStates.Add(req);
        }

        public void UpdateUsaState(UsaState req)
        {
            //throw new NotImplementedException();
        }

        public void DeleteUsaState(UsaState req)
        {
            if (req == null)
            {
                throw new ArgumentNullException(nameof(req));
            }

            _context.UsaStates.Remove(req);
        }
    }
}