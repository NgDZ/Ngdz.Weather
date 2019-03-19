using Ngdz.Weather.Metar.Entity;
using NString;
using System.Text;

namespace Ngdz.Weather.MetarDisplay
{
    public class TemperaturesMetadata : Metadata
    {
        /// <inheritdoc/>
        public override void Parse(DecodedMetar decodedMetar)
        {
            var temperatures = new StringBuilder();
            if (decodedMetar.AirTemperature != null)
            {
                // For temperatures, original unit is degree Celsius
                temperatures.Append(
                    StringTemplate.Format(
                        strings.TemperaturesDetails,
                        new
                        {
                            airTemperatureC = decodedMetar.AirTemperature.ActualValue,
                            airTemperatureF = decodedMetar.AirTemperature.ActualValue.ConvertCelsiusToFahrenheit(),
                            dewTemperatureC = decodedMetar.DewPointTemperature.ActualValue,
                            dewTemperatureF = decodedMetar.DewPointTemperature.ActualValue.ConvertCelsiusToFahrenheit(),
                        }, false));
            }
            Label = strings.TemperaturesLabel;
            Message = temperatures.ToString();
        }
    }
}
