#region Using

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartAdmin.Seed.Configuration;
using SmartAdmin.Seed.Data.Repositories.Dtos;
using SmartAdmin.Seed.Data.Repositories.Interfaces;
using SmartAdmin.Seed.Models.DemoViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

#endregion

namespace SmartAdmin.Seed.Controllers
{
    [Authorize(Roles = "ReportViewers")]
    [Route("[controller]/[action]")]    
    public class DemoController : Controller
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;
        private readonly OpenWeatherMapSettings _weatherReportConfig;
        public DemoController(
            IWeatherForecastRepository weatherForecastRepository, IOptions<OpenWeatherMapSettings> config)
        {
            _weatherForecastRepository = weatherForecastRepository;
            _weatherReportConfig = config.Value;
        }

        public async Task<IActionResult> Report()
        {
            var forecasts = new List<OpenWeatherDto>();

            foreach (var city in _weatherReportConfig.Cities)
            {
                forecasts .Add( await _weatherForecastRepository.GetForecastByCity(city) );
            }
            return View("Report", new ReportViewModel(forecasts));
        }





    }
}
