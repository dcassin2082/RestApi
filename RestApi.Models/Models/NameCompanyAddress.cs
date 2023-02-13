using System;
using System.Collections.Generic;

namespace RestApi.Models.Models;

public partial class NameCompanyAddress
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }
}
