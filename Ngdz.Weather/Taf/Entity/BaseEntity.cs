using System.Collections.Generic;

namespace Ngdz.Weather.Taf
{
    public class AbstractEntity
    {
        /// <summary>
        /// An evolution can contain embedded evolutions with different probabilities
        /// </summary>
        public List<Evolution> Evolutions { get; set; } = new List<Evolution>();
    }
}
