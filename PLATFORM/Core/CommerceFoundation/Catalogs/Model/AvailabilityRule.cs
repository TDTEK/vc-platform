﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtoCommerce.Foundation.Catalogs.Model
{
    public enum AvailabilityRule
    {
        Always = 0,
        WhenInStock,
        OnBackorder,
        OnPreorder
    }
}
