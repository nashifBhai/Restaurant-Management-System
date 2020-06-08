using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestuarantManagementSystemClass;

namespace RestuarantManagementSystemRepo
{
    interface IFoodRepository
    {

        bool Insert(Food a);
       bool Update(Food a);
       bool Delete(string FoodId);
       Food GetFood(string FoodId);
       List<Food> GetAllFoods();
    }
}
