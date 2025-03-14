using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project6_ApiWeather.Context;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        WeatherContext context=new WeatherContext();

        [HttpGet]
        public ActionResult WeatherCityList()
        {
            var values=context.Cities.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateWeatherCity(City city) 
        {
            context.Cities.Add(city);
            context.SaveChanges();
            return Ok("Şehir Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteWeatherCity(int id)
        {
            var values = context.Cities.Find(id);
            context.Cities.Remove(values);
            context.SaveChanges();
            return Ok("Şehir Silindi");
        }

        [HttpPut]
        public IActionResult UpdateWeatherCity(City city)
        {
            var value=context.Cities.Find(city.CityId);
            value.CityName = city.CityName;
            value.Temperature = city.Temperature;
            value.Country = city.Country;
            value.Detail = city.Detail;
            context.SaveChanges();
            return Ok("Şehir Güncellendi");
        }

        [HttpGet("GetByIdWeatherCity")]
        public IActionResult GetByIdWeatherCity(int id)
        {
            var value= context.Cities.Find(id);
            return Ok(value);
        }

        [HttpGet("TotalCityCount")]
        public IActionResult TotalCityCount()
        {
            var value=context.Cities.Count();
            return Ok(value);
        }

        [HttpGet("MaxTempCity")]
        public IActionResult MaxTempCity()
        {
            var value=context.Cities.OrderByDescending(x => x.Temperature).Select(y=>y.CityName).FirstOrDefault();
            return Ok(value);
        }

        [HttpGet("MinTempCity")]
        public IActionResult MinTempCity()
        {
            var value = context.Cities.OrderByDescending(x => x.Temperature).Select(y => y.CityName).LastOrDefault();
            return Ok(value);
        }
    }
}
