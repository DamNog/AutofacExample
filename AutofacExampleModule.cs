using Autofac;
using AutofacExample.Implementations;
using AutofacExample.Managers;
using AutofacExample.Services;
using System;

namespace AutofacExample
{
  public class AutofacExampleModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<PhoneService>().AsImplementedInterfaces();
      builder.RegisterType<PhoneManager>().AsImplementedInterfaces();
    }
  }
}
