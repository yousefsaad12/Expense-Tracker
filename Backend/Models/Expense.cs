using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string Name { get; set; }
        public string ? Description { get; set; }
        public decimal Amount { get; set; }

        public DateTime ExpenseDate { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public int CategoryId { get; set; }
    }
}