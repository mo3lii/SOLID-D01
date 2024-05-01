using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D01_OCP_Problem
{
    public class PaymentProcessor
    {
        public void ProcessPayment(PaymentType type, double amount)
        {
            switch (type)
            {
                

            }
        }
    }
    public enum PaymentType
    {
        CreditCard,
        PayPal,
        BankTransfer
    }
}
