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
    /// Represents base class for an Apartment model
    /// </summary>
    public class Apartment
    {
        /// <summary>
        /// Id for the Apartment model
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApartmentId { get; set; }
        /// <summary>
        /// Tag or label for the APartment model
        /// </summary>
        [Required]
        public string? ApartmentTag { get; set; }
        [Required]
        public int ApartmentTypeId { get; set; }
        public ApartmentType? ApartmentType { get; set; }

        public int BuildingId { get; set; }
        public Building? Building { get; set; }
        [Required]
        public double Amount { get; set; } = 0.00;
        //public int BillingCategoryId { get; set; }
        // public BillingCategory BillingCategory { get; set; }
        public bool Occupied { get; set; } = false;
        public int OccupiedBy { get; set; }

    }
}
