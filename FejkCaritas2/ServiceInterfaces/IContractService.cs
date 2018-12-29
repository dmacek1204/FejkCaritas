﻿using System.Collections.Generic;

namespace FejkCaritas2.ServiceInterfaces
{
    interface IContractService
    {
        Contract GetContract(int id);
        IEnumerable<Contract> GetContractsForVolunteer(int volunteerID);
        bool AddContract(Contract contract);
        bool UpdateContract(Contract contract);
        bool DeleteContract(int id);
    }
}
