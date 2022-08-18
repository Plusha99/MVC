using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Name")]
        [Required(ErrorMessage ="This field is reqired")]
        [MaxLength(12, ErrorMessage ="Maximum 12 character only")]
        public string AccountName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This field is reqired")]
        public string BeneficiaryName { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is reqired")]
        public string BankName { get; set; }
        
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is reqired")]
        [MaxLength(11,ErrorMessage ="Maximum 11 character only")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "This field is reqired")]
        public int Amout { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
