using SOLID_D01_OCP_Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D01
{
    public interface IPaymentMethod
    {
        public void ProcessPayment(double amount);
    }

    public class CrediCard : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
           //;
        }
    }
    public class PayPal : IPaymentMethod 
    { 
        public void ProcessPayment(double amount) {
        //code
        } 
    }
    public class BankTransfer : IPaymentMethod
    {
        public void ProcessPayment(double amount) {
        //code
        }
    }

    public  class Payment
    {
        public void Pay(IPaymentMethod paymentMethod, double amount)
        {
            paymentMethod.ProcessPayment(amount);
        }
    }
}
