using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4_Deque
{
    internal class MainFile
    {
        static void Main() {
            Deque<string> usersDeck = new Deque<string>();
            usersDeck.AddFirst("Alice");
            usersDeck.AddFirst("Tom");
            usersDeck.AddLast("Kate");
            usersDeck.AddLast("Tom");
            usersDeck.Print();

            
            Console.WriteLine("index elem Tom: " );
            foreach (int elem in usersDeck.Found("Tom"))
                Console.Write(elem+" ");
            Console.WriteLine();

            string removedItem = usersDeck.RemoveFirst();
            Console.WriteLine("\n Удален: {0} \n", removedItem);
            usersDeck.Print();
            
            removedItem = usersDeck.RemoveLast();
            Console.WriteLine("\n Удален: {0} \n", removedItem);
            usersDeck.Print();
            
            usersDeck.RemoveFound("Kate");
            
            usersDeck.Print();


          
        }
    }
}

