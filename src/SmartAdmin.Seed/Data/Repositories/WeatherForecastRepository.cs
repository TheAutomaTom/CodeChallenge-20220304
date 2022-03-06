using Microsoft.Extensions.Options;
using SmartAdmin.Seed.Configuration;
using SmartAdmin.Seed.Data.Repositories.Dtos;
using SmartAdmin.Seed.Data.Repositories.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace SmartAdmin.Seed.Data.Repositories
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private HttpClient _client { get; set; }
        private readonly OpenWeatherMapSettings _config;
        public WeatherForecastRepository(IOptions<OpenWeatherMapSettings> config)
        {
            _client = new HttpClient();
            _config = config.Value;
        }

        public async Task<OpenWeatherDto> GetForecastByCity(string city)
        {            
            var response = await _client.GetAsync(
                $"{_config.BaseAddress}weather?q={city}&appid={_config.AppId}&units={_config.PreferredUnits}"
            );

            var content = await response.Content.ReadAsStringAsync();

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            {
                var settings = new DataContractJsonSerializerSettings();                
                var serializer = new DataContractJsonSerializer(typeof(OpenWeatherDto));
                var forecast = (OpenWeatherDto)serializer.ReadObject(stream);
                return forecast;
            }

        }


    }
}
