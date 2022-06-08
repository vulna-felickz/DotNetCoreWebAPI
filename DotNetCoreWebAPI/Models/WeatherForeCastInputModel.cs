using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreWebAPI.Controllers
{
    public class WeatherForeCastInputModel
    {
        public long Id { get; set; }

        /// <summary>
        /// The ZipCode (USA)
        /// </summary>
        [Required]
        [SwaggerSchema(Description = "ZipCode (USA)")]
        public string ZipCode { get; set; } = null!;

        [DefaultValue(false)]
        public bool IsComplete { get; set; }
    }
}