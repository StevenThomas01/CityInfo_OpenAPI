using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    /// <summary>
    /// A city with Id, Name, Description, NumberOfPointsOfInterest and 
    /// PointsOfInterest
    /// </summary>
    public class CityDto
    {
        /// <summary>
        /// The Id of the city
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Name of the City
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the city
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of points of interest for city
        /// </summary>
        public int NumberOfPointsOfInterest { get
            {
                return PointsOfInterest.Count;
            }
        }

        /// <summary>
        /// Point of inteset for city
        /// </summary>
        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; }
        = new List<PointOfInterestDto>();
    }
}
