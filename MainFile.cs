using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3._Class_array{    
    internal class MainFile{
        static void Main(){

            Console.WriteLine("Write range of array:");
            int n = int.Parse(Console.ReadLine());
            Class1 array1 = new Class1(n);
            Console.WriteLine("Write range of array:");
            n = int.Parse(Console.ReadLine());
            Class1 array2 = new Class1(n);
            array2.InputDataRandom();

            Console.WriteLine(
                "Выберите действие: \n"+
                "2. добавить елемент в массив\n" +
                "3. заполнить массив с помощью датчика\n" +
                "4. вывод на экран содержимого массива из указанного диапазона индексов\n" +
                "5. вывести список индексов для искомого элемента \n" +
                "6. удалить из массива искомый элемент \n" +
                "7. найти максимальное значение из массива.\n" +
                "8. сложить массивы\n" +
                "9. отсортировать по возрастанию\n" +
                "10. выход\n");

            int doing = 0;
            while (doing != 10) {
                Console.Write("\n Chossen doing:");
                doing = int.Parse(Console.ReadLine());

                switch (doing) {
                    case 2:
                        Console.Write("elem=");
                        int elem = int.Parse(Console.ReadLine());
                        array1.InputData(elem);
                        break;
                    case 3:
                        array1.InputDataRandom();
                        break;
                    case 4:
                        Console.Write("start index=");
                        int start = int.Parse(Console.ReadLine());
                        Console.Write("end index=");
                        int end = int.Parse(Console.ReadLine());
                        array1.Print(start, end);
                        break; 
                    case 5:
                        Console.Write("elem=");
                        elem = int.Parse(Console.ReadLine());
                        int[] a = new int[0];   
                        array1.FindValue(elem, ref a);
                        foreach (int i in a){
                            Console.Write(i + " ");
                        }
                        break;
                    case 6:
                        Console.Write("elem=");
                        elem = int.Parse(Console.ReadLine());
                        array1.DelValue(elem);
                        break;
                    case 7:
                        int max=-1000;
                        array1.FindMax(ref max);
                        Console.WriteLine("Max= "+ max);
                        break;
                    case 8:
                        Console.Write("\n array 1:");
                        array1.Print(0, array1.get()-1);
                        Console.Write("\n array 2:");
                        array2.Print(0, array2.get()-1);
                        Console.Write("\n Sum:");
                        int[] res = new int[0];
                        array1.Add(array2, ref res);
                        foreach(int i in res) {
                            Console.Write(i+" ");
                        }
                        break;
                    case 9:
                        array1.Sort();  
                        break;
                }
            } 
        }
    }
}
