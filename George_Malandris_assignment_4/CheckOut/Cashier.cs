using George_Malandris_assignment_4.Enums;
using George_Malandris_assignment_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Malandris_assignment_4.CheckOut
{
    public class Cashier
    {
        private IProduct _product;
        private IPayment _paymentMethod;

        public Cashier(IProduct product, IPayment paymentMethod)
        {
            _product = product;
            _paymentMethod = paymentMethod;
        }

        public void CheckOut()
        {
            _product.ShowInfo();
            Console.WriteLine($"Price: {_product.GetPriceTag()}");
            _paymentMethod.Pay();
            Console.WriteLine();
        }
    }
}
