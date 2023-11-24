using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2Bakker
{
    internal interface InterfacePeople
    {
       public string Name { get; set; }
       public int CountOrder { get; set; }
       public int Productivity { get; set; }   
       public bool TakenTask { get; set; }
       public bool HavePizza { get; set; } 
    }
}
