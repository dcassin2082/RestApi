using System;
using System.Collections.Generic;

namespace RestApi.Models.Models;

public partial class TempTable
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? StreetAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? CompanyName { get; set; }
}
