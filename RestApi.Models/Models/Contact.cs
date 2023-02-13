﻿using System;
using System.Collections.Generic;

namespace RestApi.Models.Models;

public partial class Contact
{
    public int ContactId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EmailAddress { get; set; }

    public string? Phone { get; set; }
}
