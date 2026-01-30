namespace WEBAPP.Models
{
    public class LoanModel
    {
        public int LoanNo { get; set; }
        public int AccountNo{ get; set; }
        public string LoanCategory{ get; set; }
        public string LoanType { get; set; }
        public string IssueDate { get; set; }
        public int Amount { get; set; }
        public string CurrentAddress { get; set; }
        public string LoanRemark { get; set; } 
    }
}
