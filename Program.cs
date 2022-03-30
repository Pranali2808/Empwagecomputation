using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empolyee Wage Computation Program\n");
            EmpAttendance.GetEmpAttendance();
            DailyEmpWage.GetDailyEmpWage();
            ParttymEmpWage.GetParttymEmpWage();
            SwitchCase.DailyEmpWage();
            MonthWage.GetMonthWage();
            TotalWage.GetTotalWage();
            Console.ReadLine();
        }
    }
}
