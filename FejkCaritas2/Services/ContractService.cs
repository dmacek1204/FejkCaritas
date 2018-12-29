using FejkCaritas.Models;
using FejkCaritas2.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;

namespace FejkCaritas2.Services
{
    public class ContractService : IContractService
    {
        private VolunteerContext _context;

        public ContractService()
        {
            this._context = new VolunteerContext();
        }

        public Contract GetContract(int id)
        {
            var result = _context.Contracts.SingleOrDefault(c => c.ID == id);
            return result;
        }

        public IEnumerable<Contract> GetContractsForVolunteer(int volunteerID)
        {
            var result = _context.Contracts.Where(c => c.VolunteerID == volunteerID).OrderBy(c => c.StartDate);

            return result.ToList();
        }

        public bool AddContract(Contract contract)
        {
            _context.Contracts.Add(contract);

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool UpdateContract(Contract contract)
        {
            var dbContract = _context.Contracts.SingleOrDefault(c => c.ID == contract.ID);
            dbContract.NumberOfHours = contract.NumberOfHours;
            dbContract.StartDate = contract.StartDate;
            dbContract.EndDate = contract.EndDate;
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteContract(int id)
        {
            var dbContract = _context.Contracts.SingleOrDefault(c => c.ID == id);
            _context.Contracts.Remove(dbContract);
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}