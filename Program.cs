using Autofac;
using AutofacExample.Implementations;
using AutofacExample.Interfaces;
using System;

namespace AutofacExample
{
  class Program
  {
    static void Main(string[] args)
    {
      var config1 = ContainerExample.Container.Resolve<IConfiguration>();
      var config2 = ContainerExample.Container.Resolve<IConfiguration>();

      Console.Write("config1 == config2   ??   ");
      Console.ReadKey();
      Console.WriteLine(Object.ReferenceEquals(config1, config2));

      var service1 = ContainerExample.Container.Resolve<IServiceExample>();
      var service2 = ContainerExample.Container.Resolve<IServiceExample>();

      Console.WriteLine();
      Console.Write("service1 == service2   ??   ");
      Console.ReadKey();
      Console.WriteLine(Object.ReferenceEquals(service1, service2));

      Console.WriteLine();
      Console.Write("service1.Configuration == service2.Configuration   ??   ");
      Console.ReadKey();
      Console.WriteLine(Object.ReferenceEquals(service1.Configuration, service2.Configuration));

      var debtorManager1 = ContainerExample.Container.Resolve<IDebtorManager>();
      var debtorManager2 = ContainerExample.Container.Resolve<IDebtorManager>();

      Console.WriteLine();
      Console.Write("debtorManager1 == debtorManager2   ??   ");
      Console.ReadKey();
      Console.WriteLine(Object.ReferenceEquals(debtorManager1, debtorManager2));

      using (var sc = ContainerExample.Container.BeginLifetimeScope())
      {
        var dm10 = sc.Resolve<IDebtorManager>();
        var dm11 = sc.Resolve<IDebtorManager>();

        Console.WriteLine();
        Console.Write("dm10 == dm11   ??   ");
        Console.ReadKey();
        Console.WriteLine(Object.ReferenceEquals(dm10, dm11));

        var config10 = ContainerExample.Container.Resolve<IConfiguration>();
        Console.WriteLine();
        Console.Write("config1 == config10   ??   ");
        Console.ReadKey();
        Console.WriteLine(Object.ReferenceEquals(config1, config10));

        var service10 = ContainerExample.Container.Resolve<IServiceExample>();
        Console.WriteLine();
        Console.Write("service1 == service10   ??   ");
        Console.ReadKey();
        Console.WriteLine(Object.ReferenceEquals(service1, service10));
      }

      Console.WriteLine("Hello World!");
    }
  }
}
