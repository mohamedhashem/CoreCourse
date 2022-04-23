using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Company
    {
        [Column("CompanyId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Company Name Is Required Field.")]
        [MaxLength(70, ErrorMessage = "Max Length for the Name is 70 Chars.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Company Address Is Required Field.")]
        [MaxLength(70, ErrorMessage = "Max Length for the Address is 70 Chars.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Company Country Is Required Field.")]
        [MaxLength(70, ErrorMessage = "Max Length for the Country is 70 Chars.")]
        public string Country { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
