using SmartAdmin.Seed.Data.Repositories.Dtos;
using System.Collections.Generic;

namespace SmartAdmin.Seed.Models.DemoViewModels
{
    public class ReportViewModel
    {
        public IEnumerable<OpenWeatherDto> Forecasts { get; set; }
        public ReportViewModel(IList<OpenWeatherDto> forecasts)
        {            
            Forecasts = forecasts;
        }
    }
}
