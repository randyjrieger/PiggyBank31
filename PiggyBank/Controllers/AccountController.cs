using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PiggyBank.Models;

namespace PiggyBank.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var accountList =_db.Accounts.Where(a=>a.Customer.Id == 1).OrderBy(a=>a.AccountType).ToList();

            return View(accountList);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var record = await _db.Accounts.SingleAsync(r => r.Id == id);

            if (record == null)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index), "Transaction", new { id = id });
        }
    }
}