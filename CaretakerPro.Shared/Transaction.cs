using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaretakerPro.Shared
{
    public class Transaction
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionID { get; set; }
        public int PersonID { get; set; }
        public int TransactionTypeId { get; set; }
        /// <summary>
        /// Amount for the tranasaction done.
        /// </summary>
        public decimal TransactionAmount { get; set; }
        //public int BillingCategoryId { get; set; }
        //public BillingCategory BillingCategory { get; set; }
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Transaction Approved/confirmed or not.
        /// </summary>
        public bool Approved { get; set; } = false;

        /// <summary>
        /// Boolean to check if transaction validity expired or not
        /// </summary>
        ///public bool Expired { get; set; } = false;
        public int ApprovedBy { get; set; } = 0;

        /// <summary>
        /// Date transaction was done.
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }
}
