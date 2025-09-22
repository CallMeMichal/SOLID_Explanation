using Correct_Example_I1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correct_Example_I1
{
    public class Service : Service1Interface, Service2Interface, Service3Interface
    {
        public void ServiceForUser1()
        {
            //logika
        }

        public void ServiceForUser2()
        {
            //logika
        }


        public void ServiceForUser3()
        {
            //logika
        }
    }
}
