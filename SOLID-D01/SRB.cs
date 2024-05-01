using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D01_SRB
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }

    public class EmployeeFinancials
    {
        public decimal CalculateYearlySalary(Employee employee)
        {
            return employee.Salary * 12;
        }
    }

    public class EmployeeReporting
    {
        public void CreateReport(Employee employee , string reportType)
        {
            //code
        }
    }

}
