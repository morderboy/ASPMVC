using ASPMVC.Models;

namespace ASPMVC.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<WeatherModel> Weather { get; set; } = new List<WeatherModel>();
    }
}
