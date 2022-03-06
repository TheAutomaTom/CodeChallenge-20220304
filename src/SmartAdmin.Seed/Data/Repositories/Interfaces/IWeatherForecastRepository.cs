using SmartAdmin.Seed.Data.Repositories.Dtos;
using System.Threading.Tasks;

namespace SmartAdmin.Seed.Data.Repositories.Interfaces
{
    public interface IWeatherForecastRepository
    {
        Task<OpenWeatherDto> GetForecastByCity(string city);
    }
}
