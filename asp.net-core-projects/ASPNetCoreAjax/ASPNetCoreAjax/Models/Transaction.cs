using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreAjax.Models
{
    public class Transaction
    {
        [Required]
        [Key]
        public int TransactionId { set; get; }

        [DisplayName("Created On")]
        public DateTime Date { set; get; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(16,MinimumLength =7, ErrorMessage = "It must contain value between 7 to 16 digits")]
        [DisplayName("Account Number")]
        public string AccountNumber { set; get; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(50, ErrorMessage = "Beneficiary name must be smaller than 50 characters")]
        [DisplayName("BeneficiaryName")]
        public string BeneficiaryName { set; get; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Amount")]
        public float Amount { set; get; }

        [Required(ErrorMessage ="This field is required")]
        [DisplayName("Transaction Type")]
        [StringLength(255)]
        public string TransactionType { set; get; }


    }
}
