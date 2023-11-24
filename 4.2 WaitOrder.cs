using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2Bakker
{
    internal class WaitOrder
    {
        bool wait=false;
        public bool Wait
        {
            set { wait = value; }   
            get { return wait; }
        }

        bool stop = false;
        public bool Stop
        {
            set { stop = value; }
            get { return stop; }
        }
    }
}
