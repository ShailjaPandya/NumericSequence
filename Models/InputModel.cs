using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NumericSequence.Models
{
    public class InputModel
    {
        [DataType(DataType.PhoneNumber, ErrorMessage = "Not a number")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Count must be a natural number")]
        [Required(ErrorMessage = "{0} You forgot to enter a number.")]
        [Display(Name = "Number")]
        public int Number { get; set; }
    }
}