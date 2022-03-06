using SmartAdmin.Seed.Data.Repositories.Dtos;
using System.Collections.Generic;

namespace SmartAdmin.Seed.Configuration
{
    /// <summary>
    ///     Contains settings that apply to the openweathermap.org api.
    /// </summary>
    public class OpenWeatherMapSettings
    {
        public string BaseAddress { get; set; }
        public string AppId { get; set; }
        public string PreferredUnits { get; set; }
        public string[] Cities { get; set; }

    }
}
