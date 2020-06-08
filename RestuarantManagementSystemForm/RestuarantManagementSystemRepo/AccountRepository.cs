using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestuarantManagementSystemClass;



namespace RestuarantManagementSystemRepo
{
    public class AccountRepository : IAccountRepository
    {
        public bool Insert(Account a)
        {
            try
            {
                string query = "INSERT into AccountTable VALUES ('" + a.AccountId + "', '" + a.Password + "','" + a.Name + "', '" + a.AccountType + "')";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Account> GetAllAccounts()
        {
            string query = "SELECT * from AccountTable";
            List<Account> aList = new List<Account>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();

                a.Name = sdr["Name"].ToString();
                a.AccountType = sdr["AccountType"].ToString();

                aList.Add(a);
            }
            return aList;
        }
        public List<string> GetAccontid()
        {
            string query = "SELECT * from AccountTable";
            List<string> aList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();

                a.Name = sdr["Name"].ToString();
                a.AccountType = sdr["AccountType"].ToString();

                aList.Add(a.AccountId);
            }
            return aList;
        }

        public bool Update(Account a)
        {
            try
            {
                string query = "UPDATE AccountTable SET Name = '" + a.Name + "', Password = '" + a.Password + "' , AccountType = '" + a.AccountType + "' WHERE AccountId= '" + a.AccountId + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(string accountId)
        {
            try
            {
                string query = "DELETE from AccountTable WHERE AccountId = '" + accountId + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Account> SearchAccounts(string text)
        {
            string query = "SELECT * from AccountTable WHERE AccountId LIKE '%" + text + "%' OR Name LIKE '%" + text + "%'";
            List<Account> aList = new List<Account>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Name = sdr["Name"].ToString();
                a.AccountType = sdr["AccountType"].ToString();

                aList.Add(a);
            }
            return aList;
        }






        public Account GetAccountType(string AccountId)
        {
            string query = "SELECT * from AccountTable WHERE AccountId= '" + AccountId + "'";
            Account a = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Name = sdr["Name"].ToString();
                
               
                a.AccountType = sdr["AccountType"].ToString();
               
            }
            dcc.CloseConnection();
            return a;

        }

        public string UserLoginVerification(Account a)
        {
            string query = "SELECT * from AccountTable WHERE AccountId= '" + a.AccountId + "' AND Password= '" + a.Password + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                //a.Name = sdr["AccountName"].ToString();
               
                a.AccountType = sdr["AccountType"].ToString();
                dcc.CloseConnection();
                return a.AccountType;
            }
            else
            {
                dcc.CloseConnection();
                return "false";
            }


        }

      

       

       
       

       

        Account IAccountRepository.GetAccount(string accountId)
        {
            throw new NotImplementedException();
        }

        List<Account> IAccountRepository.GetAllAccounts()
        {
            throw new NotImplementedException();
        }
    }
}
