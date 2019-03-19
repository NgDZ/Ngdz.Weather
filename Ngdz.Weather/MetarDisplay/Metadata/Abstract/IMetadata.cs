using Ngdz.Weather.Metar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngdz.Weather.MetarDisplay
{
   public interface IMetadata
    {
        void Parse(DecodedMetar decodedMetar);
    }
}
