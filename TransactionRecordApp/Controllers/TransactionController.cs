using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TransactionRecordApp.Entities;

namespace TransactionRecordApp.Controllers
{
    /// <summary>
    /// Controls the Add, Edit and Delete functions
    /// </summary>


    public class TransactionController : Controller
    {
        // Private transaction DB context field
        private TransactionDbContext _transactionDbContext;
        
        // Constructor to set the Db context
        public TransactionController (TransactionDbContext transactionDbContext)
        {
            _transactionDbContext = transactionDbContext;
        }
        
        // Action to get a view with the all transactions in the model
        public IActionResult List()
        {
            // Get list of transactions,
            // Ordered alphabetically by company name 
            List<Transaction> transactions = _transactionDbContext.Transaction.OrderBy(t => t.CompanyName).ToList();

            return View("List", transactions);
        }
    }
}
