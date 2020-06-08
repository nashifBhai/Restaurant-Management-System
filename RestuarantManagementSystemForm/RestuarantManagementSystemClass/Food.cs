using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarantManagementSystemClass
{
    public class Food
    {
        private string foodId;
       
        private string foodName;
        private float foodPrice;

        public string FoodId
        {
            get { return foodId; }
            set { foodId = value; }
        }
       
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }

        public float FoodPrice
        {
            get { return foodPrice; }
            set { foodPrice = value; }
        }


    }
}
