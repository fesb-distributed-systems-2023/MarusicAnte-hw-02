/*
 **********************************
 * Author: Ante Marušić
 * Project Task: Weather Station
 **********************************
 * Description:
 *  A program that has a list of different weather stations.
 *  The program has 3 endpoints:
 *      1. Takes two parameters (Temperature name, Weather Station name) from Route.
 *         Returns a response with status 200 OK and a text (temperature value and weather station).
 *      2. Takes two parameters (Temperature name, Weather Station name) from Query.
 *         Returns a response with status 200 OK and a text (temperature value and weather station).
 *      3. Takes one parameter (Weather Station name) from Body.
 *         Returns a response with status 200 OK and a text "Hello" from specific weather station.
 **********************************
 */


using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeatherStation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherStationController : ControllerBase
    {
        // Endpoint 1
        [HttpGet("reading/{temperatureName}/{weatherStationName}")]
        public IActionResult GetReadingFromRoute(string temperatureName, string weatherStationName)
        {
            string responseText = $"Temperature {temperatureName} reading at {weatherStationName} Weather Station :: from route";
            return Ok(responseText);
        }

        // Endpoint 2
        [HttpGet("readingquery")]
        public IActionResult GetReadingFromQuery([FromQuery] string temperatureName, [FromQuery] string weatherStationName)
        {
            string responseText = $"Temperature {temperatureName} reading at {weatherStationName} Weather Station :: from query";
            return Ok(responseText);
        }

        // Endpoint 3
        [HttpPost("greeting")]
        public IActionResult GreetFromWeatherStation([FromBody] string weatherStationName)
        {
            string responseText = $"Hello from {weatherStationName} Weather Station!";
            return Ok(responseText);
        }
    }
}
