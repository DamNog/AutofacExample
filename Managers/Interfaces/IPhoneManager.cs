using AutofacExample.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutofacExample.Managers.Interfaces
{
  interface IPhoneManager
  {
    Task<int> AddPhones(IEnumerable<PhoneDto> phones);

    int GetPhonesCount();
  }
}
