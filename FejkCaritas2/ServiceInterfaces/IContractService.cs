using System.Collections.Generic;

namespace FejkCaritas2.ServiceInterfaces
{
    interface IContractService
    {
        int GetContractCountForVolunteer(int volunteerID);
        Contract GetContract(int id);
        IEnumerable<Contract> GetContractsForVolunteer(int volunteerID, int pageIndex, int pageSize);
        bool AddContract(Contract contract);
        bool UpdateContract(Contract contract);
        bool DeleteContract(int id);
    }
}
