using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    [Table("Department" , Schema = "HR")]
    class Department
    {
        [Key] // PK
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Identity
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [InverseProperty("Dept")]
        public virtual ICollection<Employee> Employees { get; set; }


        [InverseProperty("Supervisor")]
        public virtual ICollection<Employee> Supervisors { get; set; }
        public virtual ICollection<Project> Projects { get; set; }



    }
}
