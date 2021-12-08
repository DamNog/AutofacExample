using AutofacExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacExample.Implementations
{
  class DebtorManager : IDebtorManager
  {
    private readonly IConfiguration configuration;
    private readonly IServiceExample serviceexample;

    public DebtorManager(IConfiguration configuration, IServiceExample serviceExample)
    {
      this.configuration = configuration;
      this.serviceexample = serviceExample;
    }

  }
}
