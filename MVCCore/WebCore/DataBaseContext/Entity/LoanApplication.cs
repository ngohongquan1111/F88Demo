using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.DataBaseContext.Entity
{
    [Table("LoanApplication")]
    public class LoanApplication
    {
        [Key]
        public int ApplicationIndex { get; set; }

        public int Amount { get; set; }

        public int CustomerId { get; set; }

        public int LoanStatus { get; set; }
    }
}