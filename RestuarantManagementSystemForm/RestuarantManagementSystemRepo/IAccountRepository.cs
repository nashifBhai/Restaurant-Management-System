using RestuarantManagementSystemClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarantManagementSystemRepo
{
    interface IAccountRepository
    {

        bool Insert(Account a);
        bool Update(Account a);
        bool Delete(string accountId);
        Account GetAccount(string accountId);
        List<Account> GetAllAccounts();
    }
}
