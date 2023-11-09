using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._Stak
{    
    internal class Stack<T>{
        T[] m;
        int _size;
        public Stack(int _size = 100){
            m = new T[_size];
            this._size = 0;
        }
        ~Stack(){
            clear();
        }
        public void push(T v){
            if (_size < 100) {
                m[_size++] = v;
                Console.WriteLine("ok");
            }
            else
                Console.WriteLine("Stack is full");
        }
        public T pop() {
            if(_size > 0) 
                return m[--_size];
            else{
                Console.WriteLine("Error!!!! Stack is empty");
                throw new System.ArgumentOutOfRangeException();                
            }
        }
        public T back() { 
            if(_size > 0)   
                return m[_size - 1];
            else {
                Console.WriteLine("Error!!!! Stack is empty");
                throw new System.ArgumentOutOfRangeException(); 
            }
        }
        public int size(){
            return _size;
        }
        public void clear() { 
            _size = 0;
            Console.WriteLine("bye");
        }
        public void exit() {
            Console.WriteLine("bye");
        }
        
    };
}
