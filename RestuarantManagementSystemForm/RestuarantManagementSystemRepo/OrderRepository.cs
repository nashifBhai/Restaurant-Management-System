using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using RestuarantManagementSystemClass;

namespace RestuarantManagementSystemRepo
{
    public class OrderRepository
    {

        public bool Insert(FoodOrder a)
        {
            try
            {
                string query = "INSERT into OrderTable VALUES ('" + a.OrderId + "', '" + a.TotalPrice + "','" + a.AccountId + "','"+a.Status+"')";
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

        public List<FoodOrder> GetAllOrder()
        {
            string query = "SELECT * from OrderTable";
            List<FoodOrder> aList = new List<FoodOrder>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                FoodOrder a = new FoodOrder();
                a.AccountId = sdr["AccountId"].ToString();
                a.TotalPrice = float.Parse((sdr["TotalPrice"].ToString()));

                a.OrderId =int.Parse((sdr["OrderId"].ToString()));
                a.Status= sdr["Status"].ToString();



                aList.Add(a);
            }
            return aList;
        }

        public List<FoodOrder> GetStatusOrder(string status)
        {
            string query = "SELECT * from OrderTable WHERE Status='"+status+"'";
            List<FoodOrder> aList = new List<FoodOrder>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                FoodOrder a = new FoodOrder();
                a.AccountId = sdr["AccountId"].ToString();
                a.TotalPrice = float.Parse((sdr["TotalPrice"].ToString()));

                a.OrderId = int.Parse((sdr["OrderId"].ToString()));
                a.Status = sdr["Status"].ToString();
               


                aList.Add(a);
            }
            return aList;
        }
        public bool Update(string a,int num)
        {
            try
            {
                string query = "UPDATE OrderTable SET Status = '" + a + "' WHERE OrderId="+num+"";
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

        public FoodOrder GetPay(int OrderId)
        {
            string query = "SELECT * from OrderTable WHERE OrderId='" + OrderId + "'";
            FoodOrder a = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                a = new FoodOrder();
                a.OrderId = int.Parse((sdr["OrderId"].ToString()));


                a.AccountId = sdr["AccountId"].ToString();
                a.TotalPrice = float.Parse((sdr["TotalPrice"].ToString()));


            }
            dcc.CloseConnection();
            return a;


        


           }




    }
}
