using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._Stak
{
    internal class MainFile
    {
        static void Main() {
            //Pervay();
            Tretiay();
        }

        static void Pervay() {
            Stack<int> s = new Stack<int>();
            string str = " ";
            int n = 0;
            Console.WriteLine("Enter to command:");
            while (str != "\n") {
                str = Console.ReadLine();
                if (Equals(str, "push") == true) {
                    n = Int32.Parse(Console.ReadLine());
                    s.push(n);
                }
                else
                if (Equals(str, "pop") == true) {
                    Console.WriteLine(s.pop());
                }
                else
                if (Equals(str, "back") == true) {
                    Console.WriteLine(s.back());
                }
                else
                if (Equals(str, "size") == true) {
                    Console.WriteLine(s.size());
                }
                else
                if (Equals(str, "clear") == true) {
                    s.clear();
                }
                else{
                    s.exit();
                    break;
                }

            }

        }
        static void Tretiay()
        {
            Stack <char> s = new Stack<char>();
            //Предполагается, что внутри каждой пары скобок нет других скобок.
            Console.WriteLine("Enter to text:");
            char[] simbols = Console.ReadLine().ToArray();
            foreach(char simbol in simbols){
                if (simbol.Equals('('))
                    s.push(simbol);
                else{
                    if (simbol.Equals(')')) {
                        if (s.size() == 1)
                            s.pop();
                        else  {
                            Console.WriteLine("No");
                            return;
                        }
                    }
                }
            }
            if (s.size() == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }


    }
}
