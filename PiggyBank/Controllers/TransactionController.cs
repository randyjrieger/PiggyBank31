using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PiggyBank.Models;

namespace PiggyBank.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TransactionController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int? id)
        {
            var transactionList = _db.Transactions.Where(a => a.Account.Id == id).ToList();

            return View(transactionList);
        }
    }
}