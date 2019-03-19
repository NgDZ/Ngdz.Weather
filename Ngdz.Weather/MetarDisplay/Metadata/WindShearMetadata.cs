using Ngdz.Weather.Metar.Entity;
using NString;
using System.Linq;
using System.Text;

namespace Ngdz.Weather.MetarDisplay
{
    /// <inheritdoc/>
    public class WindShearMetadata : Metadata
    {
        public override void Parse(DecodedMetar decodedMetar)
        {
            var windshear = new StringBuilder();
            if (decodedMetar.WindshearAllRunways ?? false)
            {
                windshear.Append($"{strings.WindshearAllRunways} ");
            }
            else if (decodedMetar.WindshearRunways?.Count > 0)
            {
                windshear.Append(string.Join(", ", decodedMetar.WindshearRunways.Select(windshearRunway =>
                    StringTemplate.Format(strings.WindshearOnRunway, 
                new
                {
                    wr = windshearRunway
                }
                )
                )));
            }
            Label = strings.WindshearLabel;
            Message = windshear.ToString();
        }
    }
}
