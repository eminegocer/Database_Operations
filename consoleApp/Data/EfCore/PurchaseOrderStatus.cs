﻿using System;
using System.Collections.Generic;

namespace consoleApp.Data.EfCore;

public partial class PurchaseOrderStatus
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();
}
