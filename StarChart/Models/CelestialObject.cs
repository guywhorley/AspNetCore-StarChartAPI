using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public class CelestialObject
    {
        /// <summary>
        /// Id property.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of celestial object.
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Id of orbited object
        /// </summary>
        public int? OrbitedObjectId { get; set; }
        /// <summary>
        /// List of celestial object satellites.
        /// </summary>
        [NotMapped]
        public List<CelestialObject> Satellites { get; set; }
        /// <summary>
        /// Timespan for orbital period.
        /// </summary>
        public TimeSpan OrbitalPeriod { get; set; }
    }
}
