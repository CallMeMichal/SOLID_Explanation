using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defect_Example_1
{
    public class Employee
    {
        //przygotowana przez dział CFO
        public void CalculatePay()
        {
            /* Implementation */

            ReguralHours reguralHours = new ReguralHours();
            reguralHours.CalculateRegularHours();

            throw new NotImplementedException();
        }

        //przygotowana przez dział COO
        public void ReportHours()
        {
            /* Implementation */
            ReguralHours reguralHours = new ReguralHours();
            reguralHours.CalculateRegularHours();

            throw new NotImplementedException();
        }

        //przygotowana przez działo CTO
        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
