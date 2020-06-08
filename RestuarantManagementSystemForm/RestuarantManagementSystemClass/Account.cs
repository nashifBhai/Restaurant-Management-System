using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarantManagementSystemClass
{
    public class Account
    {
        private string accountId;
        private string password;
        private string name;
        private string accountType;

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
    }
}
