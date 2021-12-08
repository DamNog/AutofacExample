using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacExample.Interfaces;

namespace AutofacExample.Implementations
{
  class Configuration : IConfiguration
  {
    public bool IsProductionMode { get; set; }
  }
}
