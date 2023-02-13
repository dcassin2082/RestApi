using System;
using System.Collections.Generic;

namespace RestApi.Models.Models;

public partial class State
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Abbreviation { get; set; }
}
