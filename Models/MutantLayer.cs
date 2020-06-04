using BlazorLeaflet.Models;

namespace BlazorLeaflet.GoogleMutant.Models
{
    public class MutantLayer : Layer
    {
        /// <summary>
        /// valid values are 'roadmap', 'satellite', 'terrain' and 'hybrid'.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// valid values are 'roadmap', 'satellite', 'terrain' and 'hybrid'.
        /// </summary>
        public object Styles { get; set; }

    }
}