
class Bekker{
        int time;
        public Bekker(){ //консткуктор
            
        }
        static void Start(int order){
            Console.WriteLine(order+" заказ начали готовить.");
        }
    }

class Deliver{
        int time;
        public Deliver(){ //консткуктор

        }
        static void Start(int order){
            Console.WriteLine(order+" заказ передали в доставку.");
        }    

    }