using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarantManagementSystemClass
{
    public class FoodOrder
    {
        private int orderId;
        private double totalPrice;
        private string accountId;
        private string status;

       
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
