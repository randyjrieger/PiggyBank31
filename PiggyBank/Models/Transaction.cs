using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyBank.Models
{
    public enum TransactionType
    {
        Deposit = 1,
        Withdrawal = 2
    }

    public class Transaction
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Logged { get; set; }

        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public double Amount { get; set; }
    }
}
