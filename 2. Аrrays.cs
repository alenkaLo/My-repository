using System;
//using System.Array;

namespace program{
    class Program{ 
        static void Main()
        {
            //1 
            //pervaya();
            //2
            //vtoraya();
            //3
           // tretaya();
            //4
            //chetvertaya();
            //5
            pitaya();

        }

        static void pervaya() {
            //1 Дан одномерный массив числовых значений, насчитывающий N элементов. Вставить группу из M новых элементов, начиная с позиции K.           
            int len,M,K,N;
             int[] array = new int[0]{};
            Random random= new Random();
            Console.WriteLine("Enter count element:");
            N=Int32.Parse(Console.ReadLine());
            Array.Resize(ref array, N);
            for(int i=0; i<N; i++){
                array[i]=random.Next(N);
            }
         
            len=array.Length;
            Console.WriteLine("Enter count new element:");
            M=Int32.Parse(Console.ReadLine());
            Array.Resize(ref array, len+M);
            len=array.Length;
            Console.WriteLine("Enter number element:");
            K=Int32.Parse(Console.ReadLine());
            while(K+M>len) {
                Console.WriteLine("Array out range. Enter number element:");
                K=Int32.Parse(Console.ReadLine());
            }
            for(int i=len-1; i>=K+M; i--){
                array[i]=array[i-M];
            }
            Console.WriteLine("Enter " + M + " numders:");
            for(int i=K; i<(K+M); i++){
                array[i]=Int32.Parse(Console.ReadLine());            
            }
            Console.WriteLine("Array: ");
            foreach (int v in array){
                Console.Write(v.ToString()+" ");
            }
        }

        static void vtoraya(){
            //2 Дан одномерный массив числовых значений, насчитывающий N элементов.
            //Поменять местами первую и вторую половины массива без использования дополнительных массивов
            int N;
            int[] array = new int[0]{};
            Random random= new Random();

            Console.WriteLine("Enter count element:");
            N=Int32.Parse(Console.ReadLine());

            Array.Resize(ref array, N);
            for(int i=0; i<N; i++){
                array[i]=random.Next(N);
            }
            foreach (int v in array){
                Console.Write(v.ToString()+" ");
            }

            Array.Resize(ref array, 3*N/2+1);
           
            if(N%2==1){
                for(int i=0; i<N/2+1; i++){
                    array[i+N]=array[i];
                }
                for(int i=0; i<N/2+1; i++){
                    array[i]=array[i+(N/2)+1];                
                    array[i+(N/2)]=array[i+N];
                }
            }
            else{ 
                for(int i=0; i<N/2; i++){
                    array[i+N]=array[i];
                    array[i]=array[i+(N/2)];
                    array[i+(N/2)]=array[i+N];
                }
            }

            Array.Resize(ref array, N);
            Console.WriteLine("\nNew array:");
            foreach (int v in array){
                Console.Write(v.ToString()+" ");
            }
        }
        static void tretaya(){
        // 3. Реализовать проект – операций над массивами, каждая подзадача реализуется в виде отдельной функции:
        // - инициализация массива с помощью датчика случайных чисел. Размер массива определяет пользователь
        // - сложение массивов поэлементно в случае равенства длины массивов
        // - умножение массива на число осуществляется поэлементно
        // - поиск общих значений двух массивов (длины массивов могут быть разные)
        // - печать значений массива
        // - упорядочивание значений массива по убыванию (без использования стандартных
        // - поиск min, max значение в массиве, среднего значения всех значений массива (без использования стандартных функций)

        int[] array=new int[0];
        int[] mas=new int[0];
        int[] res = new int[0];
        int n=1;
         Console.WriteLine (
            "0.выход\n"+
            "1.инициализация первого массива \n"+
            "2.инициализация первого массива \n"+
            "3.сложение массивов поэлементно \n"+
            "4.умножение массива на число\n"+
            "5.поиск общих значений двух массивов \n"+
            "7.печать массивов\n"+
            "8.поиск max\n"+
            "9.поиск min\n"+
            "10.поиск среднего значения\n");
        
        while(n!=0){
            Console.WriteLine("Enter number funstion:");
            n=Int32.Parse(Console.ReadLine());
            switch (n) {
                case 0: break;
                case 1: intilisation(ref array); break;
                case 2: intilisation(ref mas);break;
                case 3: sum(array, mas, ref res);print(res);break;
                case 4: mutiplase(array, ref res);print(res);break;
                case 5: found(array, mas, ref res);print(res);break;
                case 6: sort(ref array); print(array);break;
                case 7:
                 Console.WriteLine("First array: ");print(array);
                 Console.WriteLine("Second array: ");print(mas);
                 Console.WriteLine("Result array: ");print(res);
                break;
                case 8: Console.WriteLine(max(array));break;
                case 9: Console.WriteLine(min(array));break;
                case 10: Console.WriteLine(medium(array));break;
                
            }
        }
        }

        static void intilisation(ref int[] a){ //из-за того что массив не инцилизорован в основной программе он не обновляется хоть и передается по ссылке. поэтому дополнительно делаю его выходным параметром
            a=new int[0];
            int N;
            Random random = new Random();

            Console.WriteLine("Enter count element:");
            N=Int32.Parse(Console.ReadLine());

            Array.Resize(ref a, N);
            for(int i=0; i<N; i++){
                a[i]=random.Next(N);
            }
        }

        static void sum(int[] a,int[] m, ref int[]s){
            if(a.Length==0 || m.Length==0){
                Console.WriteLine("Index was outside the bounds of the array.");
                return;
            }
            s= new int[0];
            Array.Resize(ref s, a.Length);
            if(a.Length==m.Length && m.Length!=0){ 
                for(int i=0; i<a.Length; i++){
                    s[i]=a[i]+m[i];
                }
            }
        }

        static void mutiplase(int[] a, ref int[]res){
            if(a.Length==0){
                Console.WriteLine("Index was outside the bounds of the array.");
                 return;
            }
            res=new int[0];
            Array.Resize(ref res, a.Length);
            int N;
            Console.WriteLine("Enter mnozhtel:");
            N=Int32.Parse(Console.ReadLine());
            for(int i=0; i<a.Length; i++){
                res[i]=a[i]*N;
            }
        }

        static void found(int[]a, int[]m, ref int[]res){
            if(a.Length==0 || m.Length==0){
                Console.WriteLine("Index was outside the bounds of the array.");
                 return;
            }
            res=new int[0];
            int i=0;           
            Array.Sort(m);
            foreach(int v in a){
                if(Array.BinarySearch(m,v)>0){
                    Array.Resize(ref res, res.Length+1);
                    res[i]=v;
                    i++;
                }
            }
        }
        static void print(int[]a){  
            if(a.Length==0){
                Console.WriteLine("Index was outside the bounds of the array.");
                 return;
            }                
            foreach (int v in a){
                Console.Write(v.ToString()+" ");
            }
            Console.WriteLine(" ");         
        }
        static void sort(ref int[]a){
            if(a.Length==0){
                Console.WriteLine("Index was outside the bounds of the array.");
                 return;
            }
            int n;
            for(int i=0; i<a.Length; i++){
                for(int j=0; j<a.Length; j++){
                    if(a[i]>a[j]){
                        n=a[i];
                        a[i]=a[j];
                        a[j]=n;
                    }
                }
            }
        }

        static int max(int[]a){
            sort(ref a);
            return a[0];
        }

    

        static int min(int[]a){
            sort(ref a);
            return a[a.Length-1];
        }
         static int medium(int[]a){
            if(a.Length==0){
                Console.WriteLine("Index was outside the bounds of the array.");
                return -1;
            }
            int n=0;
            foreach(int v in a) {
                n=n+v;
            }
            n=n/(a.Length);
            return n;
         }

         static void chetvertaya(){
            //В кинотеатре n рядов по m мест в каждом. В 
            //двумерном массиве хранится информация о проданных
            //билетах, число 1 означает, что билет на данное место уже продано,
            // число 0 означает, что место свободно. Поступил запрос на продажу k
            // билетов на соседние места в одном ряду. Определите, можно ли выполнить такой запрос.
            int n, m,k, count=0;
            Console.Write("Enter range cinema:\n n=");
            n=Int32.Parse(Console.ReadLine());
            Console.Write(" m=");
            m=Int32.Parse(Console.ReadLine());

            int[,] array = new int[n, m];
            Random ran = new Random();
            // Инициализируем данный массив
            for (int i = 0; i < n; i++) {
                string line = Console.ReadLine();
                string[] ln = line.Split(new char[]{' '});
                for (int j = 0; j<m; j++) {
                    array[i,j]=Int32.Parse(ln[j]);
                }
            }
            Console.Write("Enter count ticket: k=");
            k=Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++){
                    if(array[i,j]==0){
                        count++;
                    }
                    else{
                        count=0;
                    }
                }
                if(count>=k){
                    Console.WriteLine("Can puy the tickets in " +(i+1)+ " row");
                    return;
                }
                count=0;
            }
            if(count<k){
                 Console.WriteLine("Can't puy the tikets");
            }
        }

        static void pitaya(){
            int n=10;
            Random random = new Random();
            int[,] array = new int [n,n];
            int[,] mas = new int [n,n];
            int[,] res = new int [n,n];
            for(int i=0; i<n; i++){
                for(int j=0;j<n;j++){ 
                    array[i,j]=random.Next(10);
                    mas[i,j]=random.Next(10);
                }
            }
            // for (int i = 0; i < n; i++) {    
            //     for(int j=0;j<n;j++){        
            //         Console.Write(array[i,j]+" ");
            //     }   
            //     Console.WriteLine("");            
            // }

            // for (int i = 0; i < n; i++) {    
            //     for(int j=0;j<n;j++){        
            //         Console.Write(mas[i,j]+" ");
            //     }   
            //     Console.WriteLine("");            
            // }
         
         
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++){
                    res[i,j]=0;
                    for(int k = 0; k < n; k++)
                       // res[i,j]=res[i,j]+array[i,k]*mas[k,j];
                       res[i*n+j]=res[i*n+j]+array[i*n+k]*mas[k*n+j];
                }             
            }

            for (int i = 0; i < n; i++) {    
                for(int j=0;j<n;j++){        
                    Console.Write(res[i,j]+" ");
                }   
                Console.WriteLine("");            
            }
        }
    }
}