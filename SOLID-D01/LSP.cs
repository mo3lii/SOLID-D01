using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D01_LSP
{
   public abstract class Account
    {
        public decimal Balance { get; protected set; }
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

    }
    public class RegularAccount : Account
    {
        public override void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class SavingAccount : Account
    {
        public decimal InterestRate { get; set; }
        public override void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}

