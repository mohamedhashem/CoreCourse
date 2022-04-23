using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Employee Name Is Required Field.")]
        [MaxLength(30,ErrorMessage ="Max Length for the Name is 30 Chars")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Age is Required Field.")]
        public int  Age { get; set; }

        [Required(ErrorMessage ="Position is Required Field.")]
        [MaxLength(20,ErrorMessage ="Max Length For Position is 20 Chars")]
        public string Position { get; set; }

        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
