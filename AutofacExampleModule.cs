using Autofac;
using AutofacExample.Implementations;
using AutofacExample.Services;
using System;

namespace AutofacExample
{
  public class AutofacExampleModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<Configuration>().AsImplementedInterfaces().SingleInstance();
      builder.RegisterType<ServiceExample>().AsImplementedInterfaces();
      builder.RegisterType<DebtorManager>().AsImplementedInterfaces().InstancePerLifetimeScope();
    }
  }
}
