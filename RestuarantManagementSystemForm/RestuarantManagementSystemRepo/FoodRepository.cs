using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestuarantManagementSystemClass;

using System.Data.SqlClient;

namespace RestuarantManagementSystemRepo
{
    public  class FoodRepository : IFoodRepository
    {

        public bool Insert(Food a)
        {
            try
            {
                string query = "INSERT into FoodTable VALUES ('" + a.FoodId + "', '" + a.FoodName + "', '" + a.FoodPrice + "')";
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

        public List<Food> GetAllFoods()
        {
            string query = "SELECT * from FoodTable";
            List<Food> aList = new List<Food>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Food a = new Food();
                a.FoodId = sdr["FoodId"].ToString();
               

                a.FoodName = sdr["FoodName"].ToString();
                a.FoodPrice = float.Parse((sdr["FoodPrice"].ToString()));

                aList.Add(a);
            }
            return aList;
        }
        public Food GetFoods(string foodname)
        {
            string query = "SELECT * from FoodTable WHERE FoodName='" + foodname + "'";
            Food a = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                 a = new Food();
                a.FoodId = sdr["FoodId"].ToString();


                a.FoodName = sdr["FoodName"].ToString();
                a.FoodPrice = float.Parse((sdr["FoodPrice"].ToString()));

             
            }
            dcc.CloseConnection();
            return a;


        }



        public bool Update(Food a)
        {
            try
            {
                string query = "UPDATE FoodTable SET FoodName = '" + a.FoodName + "', FoodPrice = '" + a.FoodPrice + "' WHERE FoodId= '" + a.FoodId + "'";
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


        public bool Delete(string FoodId)
        {
            try
            {
                string query = "DELETE from FoodTable WHERE FoodId = '" + FoodId + "'";
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



        public List<Food> SearchFood(string text)
        {
            string query =
            "SELECT * from FoodTable WHERE FoodId LIKE '%" + text + "%' OR FoodName LIKE '%" + text + "%'";
            List<Food> aList = new List<Food>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Food a = new Food();
                a.FoodId = sdr["FoodId"].ToString();


                a.FoodName = sdr["FoodName"].ToString();
                a.FoodPrice = float.Parse((sdr["FoodPrice"].ToString()));

                aList.Add(a);
            }
            return aList;
        }

        Food IFoodRepository.GetFood(string FoodId)
        {
            throw new NotImplementedException();
        }

    }
}
