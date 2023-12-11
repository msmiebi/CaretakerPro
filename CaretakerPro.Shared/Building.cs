using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaretakerPro.Shared
{
    /// <summary>
    /// Represents base class for a building model.
    /// </summary>
    public class Building
    {

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BuildingId { get; set; }
        /// <summary>
        /// Gets or sets the building address 
        /// </summary>
        [Required]
        public string BuildingAddress { get; set; }

        /// <summary>
        /// Gets or sets the description of the building.
        /// </summary>
        public string Description { get; set; }
        //public ICollection<Apartment> Apartments { get; set; }
    }

}
