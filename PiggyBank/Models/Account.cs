using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyBank.Models
{
    public enum AccountType
    {
        Chequing = 1,
        Savings = 2
    }

    public class Account
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }
        public AccountType AccountType { get; set; }

        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public double Balance { get; set; }
    }
}
