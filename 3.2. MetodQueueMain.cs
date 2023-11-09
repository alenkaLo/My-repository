using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_queue{
    public class Program{
        static  void Main(){
            Queue s = new Queue();
            string str;
            int n = 0;
            str = " ";
            Console.WriteLine("Enter to command:");
            while (str != "\n")
            {
                str = Console.ReadLine();
                if (Equals(str, "push") == true)
                {
                    n = Int32.Parse(Console.ReadLine());
                    s.push(n);
                }
                else
                if (Equals(str, "pop") == true)
                {
                    Console.WriteLine(s.pop());
                }
                else
                if (Equals(str, "front") == true)
                {
                    Console.WriteLine(s.front());
                }
                else
                if (Equals(str, "size") == true)
                {
                    Console.WriteLine(s.size());
                }
                else
                if (Equals(str, "clear") == true)
                {
                    s.clear();
                }
                else
                {
                    s.exit();
                    break;
                }

            }
        }
    }
}
