using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaretakerPro.Shared
{
    public class PersonCategory
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonCategoryId { get; set; }
        public string CategoryDesc { get; set; }
        //public ICollection<Person> People { get; set; }
    }
}
