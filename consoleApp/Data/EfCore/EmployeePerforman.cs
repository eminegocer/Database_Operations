using System;
using System.Collections.Generic;

namespace consoleApp.Data.EfCore;

public partial class EmployeePerforman
{
    public int EmployeeId { get; set; }

    public string? FullName { get; set; }

    public string Email { get; set; } = null!;

    public int? SatisAdedi { get; set; }
}
