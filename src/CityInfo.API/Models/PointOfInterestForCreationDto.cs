using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    /// <summary>
    /// Point of interest with name and description.
    /// </summary>
    public class PointOfInterestForCreationDto
    {

        /// <summary>
        /// The point of interest name.
        /// </summary>
        [Required(ErrorMessage ="You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// The point of interest description.
        /// </summary>
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
