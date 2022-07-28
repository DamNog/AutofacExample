using AutofacExample.Dtos;
using AutofacExample.Managers.Interfaces;
using AutofacExample.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacExample.Managers
{
  internal class PhoneManager : IPhoneManager
  {
    private IPhoneService _phoneService;

    public PhoneManager(IPhoneService phoneService)
    {
      this._phoneService = phoneService;
    }

    public Task<int> AddPhones(IEnumerable<PhoneDto> phones)
    {
      
        int idx = 0;
        do
        {
          var list = phones.ToList();
          var phoneForAdd = list.First(p => p.Id == idx);

          var result = this._phoneService.AddPhoneAsync(phoneForAdd).Result;
          if(result != 1)
          {
            throw new ArgumentException("Error occurred while adding phone");
          }
        } while (idx++ < (phones.Count()-1));
        return Task.FromResult(idx);
    }


    public int GetPhonesCount()
    {
      return this._phoneService.GetPhoneCount().Result;
    }
  }
}
