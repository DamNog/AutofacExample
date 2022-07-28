using AutofacExample.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AutofacExample.DummyDataForTest
{
  public static class PhoneData
  {
    public static IEnumerable<PhoneDto> ListPhones_1000 = CreateDummyPhones(1000);
    public static IEnumerable<PhoneDto> ListPhones_10000 = CreateDummyPhones(10000);
    public static IEnumerable<PhoneDto> ListPhones_100000 = CreateDummyPhones(100000);

    private static IEnumerable<PhoneDto> CreateDummyPhones(int v)
    {
      foreach(var i in Enumerable.Range(0, v))
      {
        yield return new PhoneDto
        {
          Id = i,
          Number = Guid.NewGuid().ToString("N"),
          Prefix = "48"
        };
      }
    }
  }
}
