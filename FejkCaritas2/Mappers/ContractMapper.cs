using FejkCaritas2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FejkCaritas2.Mappers
{
    public class ContractMapper
    {
        public ContractView MapContractToContractView(Contract contract)
        {
            var result = new ContractView()
            {
                ID = contract.ID,
                StartDate = contract.StartDate,
                EndDate = contract.EndDate,
                NumberOfHours = contract.NumberOfHours,
                CreationDate = contract.CreationDate,
                VolunteerID = contract.VolunteerID
            };
            return result;
        }

        public IEnumerable<ContractView> MapContractCollectionToContractViewCollection(IEnumerable<Contract> contractColl)
        {
            var result = new List<ContractView>();
            foreach(var contract in contractColl)
            {
                result.Add(MapContractToContractView(contract));
            }
            return result;
        }

        public Contract MapContractViewToContract(ContractView contract)
        {
            var result = new Contract()
            {
                ID = contract.ID,
                StartDate = contract.StartDate,
                EndDate = contract.EndDate,
                NumberOfHours = contract.NumberOfHours,
                CreationDate = contract.CreationDate,
                VolunteerID = contract.VolunteerID
            };
            return result;
        }
    }
}