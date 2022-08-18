using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code Frist 
            #region commands 
            //enable-migrations one time after creation
            //add-migration fileName generate structure of datebase without create it on DBMS
            //update-datebase
            #endregion

            Context context = new Context();

            //context.Departments.Add(new Department { Name = "IT" } );
            //context.Departments.Add(new Department { Name = "IS" });
            //context.Employees.Add(new Employee {
            //    Address = "EGY",
            //    birthDate = DateTime.Now,
            //    DepartmentID = 1,
            //    Location = "eg" ,
            //    Name = "saber",
            //    Salary= 5405 ,

            //});
           
            //context.SaveChanges();

            var q =
                from epms in context.Employees
                select epms;
            //from dep in context.Departments
            //select dep;

            foreach (var em in q)
                Console.WriteLine($"{ em.Name} \t {em.Address} \t {em.Salary}");

        }
    }
}
