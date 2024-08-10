using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class Expense
{
    public int ExpenseId { get; set; }

    public decimal Amount { get; set; }

    public int? CategoryId { get; set; }

    public string? Description { get; set; }

    public DateTime ExpenseDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string Name { get; set; } = null!;

    public virtual Category? Category { get; set; }
}
