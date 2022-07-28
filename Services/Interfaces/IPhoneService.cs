using AutofacExample.Dtos;
using System.Threading.Tasks;

namespace AutofacExample.Services.Interfaces
{
  public interface IPhoneService
  {
    Task<int> AddPhoneAsync(PhoneDto phone);

    Task<int> GetPhoneCount();
    
    Task<PhoneDto> GetPhoneDtoAsync(int id);
  }
}
