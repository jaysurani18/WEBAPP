using System.ComponentModel.DataAnnotations;

namespace WEBAPP.Models
{
    public class LoanModel
    {
        [Required(ErrorMessage = "*")]
        public int LoanNo { get; set; }

        [Required(ErrorMessage = "*")]

        public int AccountNo{ get; set; }

        [Required(ErrorMessage = "*")]

        public string LoanCategory{ get; set; }

        [Required(ErrorMessage = "*")]

        public string LoanType { get; set; }

        [Required(ErrorMessage = "*")]

        public string IssueDate { get; set; }

        [Range(50000,2000000,ErrorMessage ="Range should be between 50000 to 2000000")]
        [Required(ErrorMessage = "*")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "*")]

        public string CurrentAddress { get; set; }

        [Required(ErrorMessage = "*")]

        public string LoanRemark { get; set; } 



    }
}
