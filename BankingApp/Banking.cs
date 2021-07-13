using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Banking
    {

        public int accountNo { get; set; }
        public string accountName { get; set; }
        public string accountType { get; set; }
        public double accountBalance { get; set; }


        public void withdrawal(double withdrawalAmount)
        {
            
            accountBalance = accountBalance - withdrawalAmount;
        }


        public void deposit(double depositAmount)
        {

            accountBalance = accountBalance + depositAmount;

        }



    }
}
