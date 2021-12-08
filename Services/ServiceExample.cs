using AutofacExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacExample.Services
{
  class ServiceExample : IServiceExample
  {
    private readonly IConfiguration configuration;
    public IConfiguration Configuration => configuration;

    public ServiceExample(IConfiguration configuration)
    {
      this.configuration = configuration;
    }
  }
}
