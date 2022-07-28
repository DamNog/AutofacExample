using AutofacExample.Dtos;
using AutofacExample.Services.Interfaces;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace AutofacExample.Services
{
  internal class PhoneService : IPhoneService
  {
    private ConcurrentDictionary<int, PhoneDto> _cache = new ConcurrentDictionary<int, PhoneDto>();

    public Task<int> AddPhoneAsync(PhoneDto phone)
    {
      for (int i = 0; i < 1000; i++)
      {
        this._cache.TryAdd(phone.Id, phone);
      }
      return Task.FromResult(1);
    }

    public Task<int> GetPhoneCount()
    {
      return Task.FromResult(this._cache.Count);
    }

    public async Task<PhoneDto> GetPhoneDtoAsync(int id)
    {
      if (this._cache.TryGetValue(id, out PhoneDto value))
      {
        await Task.Delay(5);
        return value;
      }
      return null;
    }
  }
}
