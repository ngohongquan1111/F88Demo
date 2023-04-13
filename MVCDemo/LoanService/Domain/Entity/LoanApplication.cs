using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDemo.Service.Domain.Entity
{
    [Table ("loanapplication")]
    public class LoanApplication
    {
        [Key]
        [Column ("ApplicationIndex")]
        public int Index { get; set; }


        public double Amount { get; set; }

        
        public int CustomerId { get; set; }

        [Column ("LoanStatus")]
        public int Status { get; set; }
    }
}