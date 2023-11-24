using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
using System.Timers;
using System.ComponentModel.DataAnnotations;

namespace _4._2Bakker
{
    internal class MainFale
    {
       static void Main()
        {
            List<Bekker> bekkers = new List<Bekker>();
            List<Deliver> delivers = new List<Deliver>();
            List<Thread> threads = new List<Thread>();
            
            Console.WriteLine("Enter count bekkers:");
            int N=Int32.Parse(Console.ReadLine());
            for(int i=0; i < N; i++)
            {
                Bekker bekker = new Bekker();
                //Console.Write("Name: ");
                //bekker.Name=Console.ReadLine();
                //Console.Write("Work Expaines: ");
                //bekker.WorkExpaines=Int32.Parse(Console.ReadLine());
                //bekker.TakenTask = false;
                //bekker.CountOrder = 0;
                Console.Write("Time of prepare one pizza: ");
                bekker.Productivity=Int32.Parse(Console.ReadLine());
                bekkers.Add(bekker);
                Thread t = new Thread(bekker.Cook);
                
                threads.Add(t);

            }

            Console.WriteLine("Enter count Deliver:");
            int M = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                Deliver deliver = new Deliver();
                //Console.Write("Name: ");
                //deliver.Name=Console.ReadLine();
                Console.Write("Volume Backpack: ");
                deliver.VolumeBackPack=Int32.Parse(Console.ReadLine());
                //deliver.TakenTask = false;
                //deliver.CountOrder = 0;
                Console.Write("Time deliverely one adress: ");
                deliver.Productivity = Int32.Parse(Console.ReadLine());
                delivers.Add(deliver);
                Thread t = new Thread(deliver.Delivery);
               
                threads.Add(t);
            }
            Console.WriteLine("Enter size save:");
            int T = Int32.Parse(Console.ReadLine());
            int countPizzeInStoke = 0;

            for (int i = 0; i < N + M; i++)
            {
                threads[i].Start();
            }

            Console.WriteLine("If you want do order - wrire 1\n\t      to end - stop");
           
            int countOrder = 0;
            int sumPizze = 0; //сумма пицц ожидающих готовку
            int timeStoke = 0;
            
            List<Order> orders = new List<Order>();
            WaitOrder wait = new WaitOrder();
            void WaitOrder()
            {
                while (true)
                {
                    if (wait.Wait == false)
                    {
                        string msg = Console.ReadLine();
                        if (msg == "stop")
                            wait.Stop = true;

                        wait.Wait = true;
                    }
                }
            }
            Thread tr = new Thread(WaitOrder);
            
            tr.Start();
            while (wait.Stop==false) 
            { 
                   //добабвляем заказ    
                if (wait.Wait == true)
                {
                    Order order = new Order();
                    Console.WriteLine("Enter orders at formate: «X-Y-count pizze»"); //X,Y={0,20}
                    string[] msg = Console.ReadLine().Split("-");
                    while(msg.Length < 3) msg = Console.ReadLine().Split("-");
                    int X, Y, countPizze = 0;
                    while (!((int.TryParse(msg[0], out X)) && (int.TryParse(msg[1], out Y)) && (int.TryParse(msg[2], out countPizze))))
                        msg = Console.ReadLine().Split("-");
                    int[] distanse = new int[2] { X, Y };

                    countOrder++;
                    order.NumerOrder = countOrder;
                    order.Distanse = distanse;
                    order.CountPizze=countPizze;
                    orders.Add(order);
                    Console.WriteLine("\t\t\t\t\t\t\t\t" + order.NumerOrder + ", order has been received.");
                    wait.Wait = false;
                    sumPizze += countPizze;
                    Console.WriteLine("If you want do order - wrire 1\n\t      to end - stop");
                }
                foreach (Order elem in orders)
                {
                    if (elem.DoneBekker == false) //выбираем невзятый заказ
                    {
                        //elem.DoneBekker = true;
                        foreach (Bekker people in bekkers) //выбираем свободного пекаря
                        {
                            if (people.TakenTask == false && sumPizze > 0 && people.HavePizza == false) //и если есть пицца которую не начали готовить
                            {
                                people.TakenTask = true; //пекарь берет пиццу и его поток остановливается, после возобновляется
                                people.CountOrder += 1; //увеличили количество взятых пицц
                                sumPizze--;
                                people.HavePizza = true;
                                
                            }

                        }
                        
                            foreach (Bekker people in bekkers)
                        {
                            if (people.TakenTask == false && elem.CountBekker < elem.CountPizze && people.HavePizza == true) //пицца приготовлена
                            {
                                people.HavePizza = false;
                                elem.CountBekker++; //увеличиваем количество готовых пицц
                                countPizzeInStoke++;
                                Console.WriteLine("\t\t\t\t\t\t\t\t" + elem.NumerOrder + ", pizza " + elem.CountBekker + " (of " + elem.CountPizze + ") have done.");
                                //здесь мы должны отнести пиццу на склад, если склад полный, people.wait = true;
                                if (countPizzeInStoke > T)
                                {
                                    timeStoke++;
                                    people.Wait = true; //в таком случае задача на пекаре висит и он не может принять следующий заказ
                                    people.TakenTask = true;
                                }
                                if (countPizzeInStoke <= T)
                                {
                                    people.Wait = false;
                                    people.TakenTask = false;
                                }
                                
                                if (elem.CountBekker == elem.CountPizze) //пекари готовят непрерывно, если есть заказы
                                {
                                    elem.DoneBekker = true;
                                    Console.WriteLine("\t\t\t\t\t\t\t\t" + elem.NumerOrder + ", everything have been cooked.");
                                }
                            }
                        }
                    }
                }
                foreach (Deliver people in delivers)
                {
                    int[] pred = new int[] { 0, 0 };
                    //дальше заказ берет курьер
                    if (people.TakenTask == false && countPizzeInStoke > 0) //
                    {
                        foreach (Order elem in orders)
                        {
                            if (elem.TakeDeliver == false && elem.DoneBekker == true && people.BackPack + elem.CountPizze <= people.VolumeBackPack) //выбираем невзятый заказ курьером, но выполненый пекарем b влезают в рюкзак
                            {
                                elem.TakeDeliver = true;
                                countPizzeInStoke -= elem.CountPizze;
                                people.TaskDistans(pred, elem.Distanse);
                                pred = elem.Distanse;
                                people.TakenTask = true; // берет пиццу и его поток остановливается, после возобновляется
                                people.CountOrder += 1;
                                people.BackPack += elem.CountPizze;
                                people.NumOrders.Add(elem.NumerOrder);
                                people.HavePizza = true;                               
                                Console.WriteLine("\t\t\t\t\t\t\t\t" + elem.NumerOrder + ", order has been delivered.");
                            }
                        }
                        
                    }
                }
                foreach (Deliver people in delivers)
                {
                    if (people.TakenTask == false && people.HavePizza == true) //пицца 
                    {
                        people.HavePizza = false;
                        foreach (Order elem in orders)
                        {
                            if (people.NumOrders.Contains(elem.NumerOrder))
                            {
                                people.BackPack -= elem.CountPizze;
                                Console.WriteLine("\t\t\t\t\t\t\t\t" + elem.NumerOrder + ", order have been done.");
                            }
                        }
                        people.NumOrders.Clear();
                       
                    }
                }
                //курьеры ожидают появления нового заказа(if order.take==false) , берет у кого в рюкзак влезают пиццы, остановили поток курьера на время S/V, пока спит его не выбирают
                // закончил доставлять курьер.готов = правда
            }

            
            if (timeStoke > 0)
                Console.WriteLine("расширить склад");
            else
                Console.WriteLine("увеличить количество заказов");

            int max = 0, min = 10000, indexMax=0, indexMin=0, j=0; 
            foreach (Bekker people in bekkers)
            {
                j++;
                if (people.CountOrder > max)
                { max = people.CountOrder; indexMax = j; }
                if (people.CountOrder < min)
                {  min = people.CountOrder; indexMin = j; } 
               
            }
            Console.WriteLine("нанять " + indexMax + " пекаря, уволить " + indexMin + " пекаря");

            max = 0; min = 10000; indexMax = 0; indexMin = 0; j = 0;
            foreach (Deliver people in delivers)
            {
                j++;
                if (people.CountOrder > max)
                { max = people.CountOrder; indexMax = j; }
                if (people.CountOrder < min)
                { min = people.CountOrder; indexMin = j; }
                
            }
            Console.WriteLine("нанять " + indexMax + " курьера, уволить " + indexMin + " курьера");



        }
    }
}
