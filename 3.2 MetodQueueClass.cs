using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_queue
{
    public class Queue
    {
        int[] m;
        int _size;
        public string SizeLessThatZeroMessege = "Size less that zero";
        public string SizeMostThatRange = "Sizo most that range";
        public Queue(int size=100) {
            this.m = new int[size];
            this._size = 0;   
        }
        ~Queue(){
            clear();
        }
        public void push(int v){
            if (_size < 100){
                m[_size++] = v;
                Console.WriteLine("ok");
            }
            else
                //Console.WriteLine("Stack is full");
                throw new System.ArgumentOutOfRangeException("_size", _size, SizeMostThatRange);
        }
        public int pop(){
            if (_size > 0) {
                int a = m[0];
                for (int i = 0; i < _size - 1; i++) 
                    m[i] = m[i + 1];
                _size--;
                return a;
            }
            else{
                //Console.WriteLine("Stack is empty");
                //return -1;
                throw new System.ArgumentOutOfRangeException("_size", _size, SizeLessThatZeroMessege);
            }
        }
        public int front()
        {
            if (_size > 0)
                return m[0];
            else{
                //Console.WriteLine("Stack is empty");
                //return -1;
                throw new System.ArgumentOutOfRangeException("_size", _size, SizeLessThatZeroMessege);
            }
        }
        public int size(){
            return _size;
        }
        public void clear(){
            _size = 0;
            Console.WriteLine("bye");
        }
        public void exit() {
            Console.WriteLine("bye");
        }

}
}
