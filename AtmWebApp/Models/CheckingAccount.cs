using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AtmMvcWebApp.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "The account number must a number having between 6 and 10 digits.")]
        [Display(Name = "Account Number")]
        public string AcountNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Name { get { return string.Format("{0} {0}", FirstName, LastName); } }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}