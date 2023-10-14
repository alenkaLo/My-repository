// See https://aka.ms/new-console-template for more information
using System;

namespace program{
    class Program{ 
        static void Main()
        {
            //1
            //pervaya();

            //2
            //vtoraya();

            //3
            //tretaya();
            
            //4
            //chetvertaya();
            
            //5
            //pitaya();

            //6
            //shestaya();

            //7
            //sedmaya();


            //9
            //devyataya();

            //10
            desyati();
        }

        static void pervaya() {
            //1 Напишите программу, которая у пользователя запрашивает три числа. Находит максимум из двух чисел и выводит на экран
            double a, b, c;
            Console.WriteLine("Enter 3 numbers");
            a = Convert.ToDouble(Console.ReadLine()); 
            b = Convert.ToDouble(Console.ReadLine());  
            c = Convert.ToDouble(Console.ReadLine());
            double max=a;
            if(b>max)
            max=b;
            if (c>max)
            max = c;
            Console.WriteLine("max="+ max);
        }

        static void vtoraya() {
            //2 Напишите программу, которая у пользователя запрашивает одно число. Находит
            //делители данного числа от 2 до 10 и выводит на экран найденные делители
            double a;
            Console.WriteLine ("Enter number");
            a = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine ("Divider for "+a+":");
            for(int i=2; i<=10; i++){
                if(a % i==0)
                {Console.WriteLine(i);}
            }
        }

        static void tretaya() {
            //3 Напишите программу, которая у пользователя запрашивает три числа
            //определяющие стороны треугольника. Определить тип треугольника:
            //равнобедренный, равносторонний, прямоугольный, обычный
            Console.WriteLine("Enter 3 numbers");
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine()); 
            b = Convert.ToDouble(Console.ReadLine());  
            c = Convert.ToDouble(Console.ReadLine());

            if(a>=b+c || b>=a+c || c>=b+a){ 
            Console.WriteLine("треугольника не существует");
            return;
            }

            if(Math.Pow(a,2)==Math.Pow(b,2)+Math.Pow(c,2) || Math.Pow(b,2)==Math.Pow(a,2)+Math.Pow(c,2) || Math.Pow(c,2)==Math.Pow(a,2)+Math.Pow(b,2)){
                Console.WriteLine("прямоугольный");
                return;
            }
            if(a==b || a==c || b==c)
            {
                Console.WriteLine("равнобедренный");
                if (a==b && b==c)
                Console.WriteLine("равносторонний");            
            }
            else{
                Console.WriteLine("обычный");
            }
        }

        static void chetvertaya() {
            //4 Используя цикл while, выведите на экран для числа 2 его степени от 0 до 20
            int i=0;
            while(i<=20){ 
            Console.WriteLine("2^"+i+"="+Math.Pow(2,i));
            i++;
            }
        }
       
        static void pitaya() {
            //5 Пользователь вводит число, посчитать до этого числа количество четных и нечетных чисел. 
            //Например ввели число 10, количество нечетных чисел – 5 (1,3,5,7,9), количество четных чисел - 5 (2,4,6,8,10)
            double a;
            Console.WriteLine("Enter number: ");
            a=Convert.ToDouble(Console.ReadLine());
            if(a%2==0)
                Console.WriteLine("четных чисел: "+a/2);
            else
                Console.WriteLine("четных чисел: "+ (Math.Round(a/2)-1));
            
            Console.WriteLine("нечетных чисел: "+  Math.Round(a/2));
        }

        static void shestaya()
        { 
            //6 Пользователь вводит два числа. Данные числа определяют числовой
            //диапазон, для которого надо найти все числа, которые делятся нацело на 3, 5, 9
            //Например диапазон 1 - 20, количество чисел, которые делятся на 3 – 6, 5 – 4, 9 - 2
            double a, b;
            Console.WriteLine("Enter 3 numbers");
            a = Convert.ToDouble(Console.ReadLine()); 
            b = Convert.ToDouble(Console.ReadLine()); 
            int tri=0, pite=0, devite=0;
            for(double i=a; i<=b; i++){
                if(i%3==0) tri++;
                if(i%5==0) pite++;
                if(i%9==0) devite++;
            }
            Console.WriteLine(" делится нацело на 3 - "+ tri +"\n делится нацело на 5 - "+ pite +"\n делится нацело на 9 - "+ devite );
        }
        
        static void sedmaya(){
        /*6 Написать программу, которая предлагает пользователю ввести 10 чисел, 
        для которых программа осуществляет поиск максимального числа, считает среднее значение*/ 

        Console.WriteLine("Введите 10 чисел");
        List<double> numbers = new List<double>();
        for (int i=0; i<10; i++) {
            numbers.Add(Convert.ToDouble(Console.ReadLine()));
        }

        double max=numbers[0];
        for(int i=1; i<10; i++) {
            if(numbers[i]>max) max=numbers[i];
        }

        Console.WriteLine("Максимальное число = " + max);
        }
        
        static void vosmaya(){
            int random_number, number_of_attempts, entered_number, i, y;
            Random random = new Random();
            do {
                // Получить случайное число
                random_number = random.Next(100);
                y = 0;
    
                number_of_attempts=0;
                i=0;
                do {
                    i++;
                    Console.WriteLine("Введите число :");
                    entered_number=Int32.Parse(Console.ReadLine());
                    if (entered_number == random_number) {
                        Console.WriteLine("Правильно. Угадано с " + i + " попытки \n");
                    }
                    else {
                        if (entered_number < random_number)
                             Console.WriteLine("загаданное число больше чем " + entered_number);
                        else
                             Console.WriteLine("загаданное число меньше чем " + entered_number);
                    }
                } while(random_number!=entered_number);
               
                Console.WriteLine("Продолжить игру Yes/No (Нажать 1, если завершить и 0, если продожить) ");
                y = Int32.Parse(Console.ReadLine());
            } while (y == 0);
            
            return;
        }
       
        static void devyataya()
        {
           // 9 Напишите программу, которая бы «Подбрасывала» условную монету
           //100 раз и сообщала, сколько раз выпал орел, а сколько — решка.
           int num, orel=0, reshka=0;
           Random ran = new Random();
           for(int j=0; j<100; j++) {
           num = ran.Next(2);
           if (num==0) reshka++;
           else orel++;
           }
           Console.WriteLine("Орел выпал " + orel + " раз \n" + "Решка выпала " + reshka + " раз");           
           }
        
        static void desyati() {
            /*10 Напишите на псевдокоде алгоритм игры, в которой случайное число от
            1 до 100 загадывает человек, а отгадывает компьютер. Прежде чем приступать к
            решению, задумайтесь над тем, какой должна быть оптимальная стратегия
            отгадывания. Если алгоритм на псевдокоде будет удачным, попробуйте реализовать
            игру на C#*/
           Console.WriteLine("Введите число :");
           int a=Int32.Parse(Console.ReadLine());
           int num=50;
           int res=0;
           do{
            if(num>a) { //a-число с которым мы сравниваем
                num=num/2;
            }
            else{     
                a=a-num;
                res+=num;
            }
           }while(a>0);
           Console.WriteLine("Введеное число : " + res);           
        }
       
       
       
    }
}