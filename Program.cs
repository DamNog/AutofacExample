using AutofacExample.PerformanceTests;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System;

namespace AutofacExample
{
  class Program
  {
    static void Main(string[] args)
    {
      //var phoneTest = new PhoneManagerTests();
      //phoneTest.Add1000Phone();
      
      var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

      //BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, new DebugInProcessConfig());

      Console.WriteLine("DONE!");
    }
  }
}
