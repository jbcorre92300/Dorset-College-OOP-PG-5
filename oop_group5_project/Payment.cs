using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Payment
    {
        public double cost;
        public double alreadypaid;

        public Payment (int a, int b)
        {
            cost = a;
            alreadypaid = b;
        }
    }
}
