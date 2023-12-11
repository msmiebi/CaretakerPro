
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CaretakerPro.Shared
{
    public class TransactionDetail
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionDetailId { get; set; }
        public int TransactionType { get; set; }

    }
}
