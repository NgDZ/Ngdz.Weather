using Ngdz.Weather.Metar.Entity;

namespace Ngdz.Weather.MetarDisplay
{
    public class RawMetarMetadata : Metadata
    {
        /// <inheritdoc/>
        public override void Parse(DecodedMetar decodedMetar)
        {
            Label = strings.RawMetarLabel;
            Message = decodedMetar.RawMetar;
        }
    }
}
