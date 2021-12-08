using Autofac;
using AutofacExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacExample.Implementations
{
  class ContainerExample
  {
    private static IContainer container;
    public static IContainer Container 
    {
      get => container ?? BuildContainer();
      set => container = value; 
    }

    /// <summary>
    /// The build container
    /// </summary>
    /// <returns></returns>
    private static IContainer BuildContainer()
    {
      var containerBuilder = new ContainerBuilder();
      containerBuilder.RegisterModule(new AutofacExampleModule());

      container = containerBuilder.Build();
      return container;
    }
  }
}
