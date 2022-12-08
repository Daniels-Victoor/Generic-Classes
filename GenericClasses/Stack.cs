using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{

    public class Stack<T> : IEnumerable<T>
    {
        //initializes an object of singleLinkedList class from the custom linkedList 
        LinkedList<T> Stacks = new LinkedList<T>();

        public int Count { get; private set; }


        //METHODS OF STACK

        //IsEmpty() - returns true if the stack is empty and false is it isn’t
        public bool IsEmpty()
        {
            if (Count == 0)
            {
                return true;
            }
            return false;
        }

        // Push(T item) – adds an item to the top of the stack

        public void Push(T Item)
        {
            Stacks.Add(Item);
            Count++;
        }

        //Pop() – removes and returns the last item added to the stack
        public T Pop()
        {
            Count--;
            return Stacks.RemoveFirstItem();

        }

        // Peek() -returns the last item added to the stack

        public T Peek()
        {
            return Stacks.ReturnLastItem();
        }


        // Size() -shows the number of items currently in the stack

        public int Size()
        {
            return Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T Item in Stacks)
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
