﻿using System;
using System.Collections.Generic;

namespace consoleApp.Data.EfCore;

public partial class Invoice
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Shipping { get; set; }

    public decimal? AmountDue { get; set; }

    public virtual Order? Order { get; set; }
}
