using _3._4_Deque;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4_Deque
{
    public class DoublyNode<T> {
        public DoublyNode(T data){
            Data = data;
        }
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }
    public class Deque<T> 
    {
        DoublyNode<T> head; 
        DoublyNode<T> tail; 
        int size; 
        public List<int> Found(T foundElem)
        {
            int count = 0;
            List<int> ints = new List<int>();
            DoublyNode<T> s = head;
            while (s != null)
            {
                if (s.Data.Equals(foundElem))
                    ints.Add(count);
                s = s.Next;
                count++;
            }
                       
            return ints;
        }
        // добавление элемента
        public void AddFirst(T data) {
            DoublyNode<T> _new = new DoublyNode<T>(data);
            DoublyNode<T> h = head;
            _new.Next = h;
            head = _new;
            if (size == 0)
                tail = head;
            else
                h.Previous = _new;
            size++;
        }

        public void AddLast(T data)   {
            DoublyNode<T> _new = new DoublyNode<T>(data);
            if (head == null)
                head = _new;
            else {
                tail.Next = _new;
                _new.Previous = tail;
            }
            tail = _new;
            size++;
        }
        public void RemoveFound(T data) {
            if (Found(data).Count == 0)
                return;
                     
            DoublyNode<T> s = head;
            while (s != null && Found(data).Count!=0)   { 
                if (s.Data.Equals(data)) {
                    if (s.Previous == null)
                        RemoveFirst();
                    else{
                        if (s.Next == null) {
                            RemoveLast();
                            
                        }
                        else {
                            DoublyNode<T> a = s.Previous;
                            s = s.Next;
                            s.Previous = a;
                            size--;
                            
                        }
                    }
                }
                else
                   s = s.Next;
            }       
        }

        public T RemoveFirst()  {
            if (size == 0)
                throw new InvalidOperationException();
            T deleteElem = head.Data;
            if (size == 1) {
                head = tail = null;
            }
            else {
                head = head.Next;
                head.Previous = null;
            }
            size--;
            return deleteElem;
        }
        public T RemoveLast()
        {
            if (size == 0)
                throw new InvalidOperationException();
            T DeleteElem = tail.Data;
            if (size == 1) {
                head = tail = null;
            }
            else {
                tail = tail.Previous;
                tail.Next = null;
            }
            size--;
            return DeleteElem;
        }
        public List<T> Value() { 
            
            List<T> a = new List<T>();
            DoublyNode<T> s = head;
            while (s != null){
                a.Add(s.Data);
                s = s.Next;
            }
            return a; 
        }
        public int Count { get { return size; } }
           
         public void Print()
        {
            DoublyNode<T> s = head;
            while (s != null)
            {
                Console.WriteLine(s.Data.ToString());
                s=s.Next;   
            }
        }
       

       
    }
}



