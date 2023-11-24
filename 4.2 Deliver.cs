using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2Bakker
{
    internal class Deliver: InterfacePeople
    {
        string _name="Deliver";   
        public string Name 
        { 
            set { _name = value; }
            get { return _name; }
        }
        int countOrder=0;
        public int CountOrder 
        {  
            set { countOrder = value; }
            get { return countOrder; }
        }

        int speed;
        public int Productivity
        {
            set { speed = value; }
            get { return speed; }
        }

        int volumeBackPack;
        public int VolumeBackPack
        {
            set { volumeBackPack = value; }
            get { return volumeBackPack; }
        }
        int backRack = 0;
        public int BackPack
        {
            set { backRack = value; }
            get { return backRack; }
        }

        bool task=false;
        public bool TakenTask
        {
            set { task = value; }   
            get { return task; }    
        }
        bool havePizza = false;
        public bool HavePizza
        {
            set { havePizza = value; }
            get { return havePizza; }
        }
        
        int taskDistanse = 0;
        public void TaskDistans(int[] pred, int[]now )
        {
            taskDistanse += ((now[0] - pred[0]) ^ 2 + (now[1] - pred[1])^2)^(1/2);
        }
        
         List<int> numOrders = new List<int>();
        public List<int> NumOrders
        {
            set {  numOrders = value; } 
            get { return numOrders; } 
        }    
        public void Delivery()
        {
            while (true)
            {
                if (task == true)
                {
                    Thread.Sleep(1000 * speed * taskDistanse);
                    task = false;
                    taskDistanse = 0;
                }
            }
        }
        
    }
}
