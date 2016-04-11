using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    class TestApp
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.FirstName = "Todor";
            employee.LastName = "Kostov";
            employee.Salary = 900;
            employee.Bonus = 200;
            employee.Position = "Sales Consultant";

            employee.PrintNames();
            employee.CalculateAllIncome();
            employee.CalculateBalance();
        }
    }
}
