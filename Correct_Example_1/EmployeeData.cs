using Correct_Example_1.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correct_Example_1
{
    public class EmployeeData
    {
        public void SaveEmployeeData()
        {
            EmployeeSaver employeeSaver = new EmployeeSaver();
            employeeSaver.Save();
        }

        public void ReportEmployeeHours()
        {
            HourReporter hourReporter = new HourReporter();
            hourReporter.ReportHours();
        }

        public void CalculateEmployeePay()
        {
            PayCalculator payCalculator = new PayCalculator();
            payCalculator.CalculatePay();
        }
    }
}
