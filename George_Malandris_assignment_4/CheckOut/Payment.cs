using George_Malandris_assignment_4.Enums;
using George_Malandris_assignment_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Malandris_assignment_4.CheckOut
{
    public class Payment : IPayment
    {
        public PaymentMethod PaymentMethod { get; set; }

        public Payment(PaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }

        public void Pay()
        {
            string method = "";
            switch (PaymentMethod)
            {
                case (PaymentMethod.DebitCard):
                    method = "Credit/Debit Card";
                    break;
                case (PaymentMethod.BankTransfer):
                    method = "Money/Bank Transfer";
                    break;
                case (PaymentMethod.Cash):
                    method = "Cash";
                    break;
                default:
                    method = "Some other time...";
                    break;
            }

            Console.WriteLine("I will pay with {0}.", method);
        }
    }
}
