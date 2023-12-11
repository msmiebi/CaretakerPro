using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaretakerPro.Shared
{
    public class ApartmentType
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApartmentTypeId { get; set; }
        [Required]
        public string Description { get; set; }
        //public ICollection<Apartment> Apartments { get; set; }
    }
}
