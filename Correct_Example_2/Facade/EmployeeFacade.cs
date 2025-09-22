using Correct_Example_2.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correct_Example_2.Facade
{
    public class EmployeeFacade
    {

        public void Save()
        {
            EmployeeSaver employeeSaver = new EmployeeSaver();
        }
        public void ReportHours()
        {
            HourReporter hourReporter = new HourReporter();
        }
        public void CalculatePay()
        {
            PayCalculator payCalculator = new PayCalculator();
        }
    }
}
