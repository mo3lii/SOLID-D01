﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D01_SRB_Problem
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public decimal CalculateYearlySalary()
        {
            return Salary * 12;
        }
        public void GenerateReport(string reportType)
        {

        }
    }
}
