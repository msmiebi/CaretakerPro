using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CaretakerPro.Shared
{
    public class Person
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }

        /// <summary>
        /// Gets or Sets the Firstname of Person
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string? Firstname { get; set; }
        public string? Middlename { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string? Lastname { get; set; }
        public int GenderId { get; set; }
        public Gender? Gender { get; set; }
        [Required]
        public string? Mobile { get; set; }
        //public string Address { get; set; }
        public string? EmailAddress { get; set; }
        public int PersonCategoryId { get; set; }
        public PersonCategory? PersonCategory { get; set; }

        public DateTime? LeaseStartDate { get; set; }
        public bool Active { get; set; }
    }
}
