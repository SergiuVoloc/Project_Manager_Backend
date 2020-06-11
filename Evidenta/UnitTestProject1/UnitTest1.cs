using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
            double m_balance;
            public void Withdraw(double amount)
            {
                if (m_balance >= amount)
                {
                    m_balance -= amount;
                }
                else
                {
                    throw new ArgumentException(nameof(amount), "Withdrawal exceeds balance!");
                }
            }
        }
    
}
