﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacExample.Interfaces
{
  public interface IConfiguration
  {
    bool IsProductionMode { get; set; }
  }
}
