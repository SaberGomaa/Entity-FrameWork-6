using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    class Employee
    {
        public int Id { get; set; }

        [MaxLength(100), Column("FullName")]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [Column("totalSalary")] // change 
        public double? Salary { get; set; } // ? allow null

        [Column(TypeName ="Date")]
        public DateTime birthDate { get; set; }

        [Required]
        public string Location { get; set; }

        public int? SupervisedDeptID { get; set; }

        //[ForeignKey("Dept")]
        public int DepartmentID { get; set; } // we make DepartmentID to save it because virtual lazy loading
        [ForeignKey("DepartmentID")] // Make it forign key
        public virtual Department Dept{ get; set; } // virtual lazy loading 
        [ForeignKey("SupervisedDeptID")]
        public virtual Department Supervisor { get; set; }
        public virtual ICollection<Project> Projects { get; set; }


    }
}
