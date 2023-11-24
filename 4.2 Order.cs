using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2Bakker
{
    internal class Order
    {
        int numerOrder;
        public int NumerOrder
        {
            set { numerOrder = value; }
            get { return numerOrder; }
        }
        int[] distanse;
        public int[] Distanse
        {
            set { distanse = value; }
            get { return distanse; }
        }
        int countPizze;
        public int CountPizze
        {
            set { countPizze = value; }
            get { return countPizze; }
        }
        int countBekker = 0;
        public int CountBekker
        {
            set { countBekker = value; }
            get { return countBekker; }
        }
        bool doneBekker = false; 
        public bool DoneBekker
        {
            set { doneBekker = value; }
            get { return doneBekker; }
        }
        int takeBekker = 0;
        public int TakeBekker
        {
            set { takeBekker = value; }
            get { return takeBekker; }
        }

        bool takeDeliver = false;
        public bool TakeDeliver
        {
            set { takeDeliver = value; }
            get { return takeDeliver; }
        }
       

       
        

          
        
    }

}
