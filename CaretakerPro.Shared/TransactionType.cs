
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CaretakerPro.Shared
{
    public class TransactionType
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionTypeID { get; set; }
        public string Description { get; set; }
    }
}
