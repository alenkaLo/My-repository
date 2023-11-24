using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2Bakker
{
    internal class Bekker : InterfacePeople
    {
        string _name="bekker";
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        int workExpaines=0;
        public int WorkExpaines
        {
            set { workExpaines = value;}
            get { return workExpaines; }
        }
        int countOrder=0;
        public int CountOrder
        {
            set { countOrder = value; }
            get { return countOrder; }
        }
        int cookingTime;
        public int Productivity
        {
            set { cookingTime = value; }
            get { return cookingTime; }
        }
        
        bool task=false;
        public bool TakenTask
        {
            set { task = value; }
            get { return task; }
        }

        bool wait = false;
        public bool Wait
        {
            set { wait = value; }
            get { return wait; }
        }

        bool havePizza = false;
        public bool HavePizza
        {
            set { havePizza = value; }
            get { return havePizza; }   
        }

       
        public void Cook()
        {
            while (true)
            {
                if (task == true && wait==false)
                {
                    Thread.Sleep(1000*cookingTime);
                    task = false;
                }                
                
            }
        }

        
    }
}

