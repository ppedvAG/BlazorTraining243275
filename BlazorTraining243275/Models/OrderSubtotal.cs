﻿using System;
using System.Collections.Generic;

namespace BlazorTraining243275.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
