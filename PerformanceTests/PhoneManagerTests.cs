using Autofac;
using AutofacExample.DummyDataForTest;
using AutofacExample.Implementations;
using AutofacExample.Managers.Interfaces;
using BenchmarkDotNet.Attributes;
using System;
using System.Linq;

namespace AutofacExample.PerformanceTests
{
  public class PhoneManagerTests
  {
    public PhoneManagerTests()
    {
    }

    [Benchmark]
    public void Add1000Phone()
    {
      var expectedCount = 1000;
     
      var phoneManager = ContainerExample.Container.Resolve<IPhoneManager>();
      phoneManager.AddPhones(PhoneData.ListPhones_1000);

      var addedPhones = phoneManager.GetPhonesCount();
      if (addedPhones != expectedCount)
      {
        throw new Exception($"Ups :( AddedPhones: {addedPhones}, expected: {expectedCount}");
      }
    }
    
    [Benchmark]
    public void Add10000Phone()
    {
      var expectedCount = 10000;

      var phoneManager = ContainerExample.Container.Resolve<IPhoneManager>();
      phoneManager.AddPhones(PhoneData.ListPhones_10000);

      var addedPhones = phoneManager.GetPhonesCount();
      if (addedPhones != expectedCount)
      {
        throw new Exception($"Ups :( AddedPhones: {addedPhones}, expected: {expectedCount}");
      }
    }

    [Benchmark]
    public void Add100000Phone()
    {
      var expectedCount = 100000;

      var phoneManager = ContainerExample.Container.Resolve<IPhoneManager>();
      phoneManager.AddPhones(PhoneData.ListPhones_100000);

      var addedPhones = phoneManager.GetPhonesCount();
      if (addedPhones != expectedCount)
      {
        throw new Exception($"Ups :( AddedPhones: {addedPhones}, expected: {expectedCount}");
      }
    }

  }
}
