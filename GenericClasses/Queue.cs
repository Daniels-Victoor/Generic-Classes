using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses    
{
    public class Queue<T> : IEnumerable<T>
    {
        LinkedList<T> queue = new LinkedList<T>();
        public int Count { get; private set; }



        //Trying to access my queue.Count(); in this class without a using a method is not working
        //count is a property of my linkedlist in my linkedlist class


        //METHODS FOR QUEUE

        //IsEmpty() - returns true if the queue is empty and false is it isn’t
        public bool QueueIsEmpty()
        {
            if (queue.Count == 0)
            {
                return true;
            }

            return false;
        }

        //Enqueue(T item) – adds an item to the tail of the queue
        public void Enqueue(T item)
        {
            queue.AddToTail(item);
            Count++;
        }


        //Dequeue() -removes and returns the item at the head of the queue
        public T Dequeue()
        {
            Count--;
            return queue.RemoveFirstItem();
        }

        //Size() -shows the number of items currently in the queue
        public int Size()
        {
            return Count;
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (T Item in queue)
            {
                yield return Item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
