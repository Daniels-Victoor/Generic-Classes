using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class Node<T>
    {
        // creating a property called value
        public T Value { get; set; }

        //creating a property of pointer pointing to the next address
        //remove or make it internal the setter, to restrict access of seting t values
        public Node<T> NextValue { get; internal set; }

    }
    public class LinkedList<T> : IEnumerable<T>
    {
        //Properties....

        //being that the first item have no pointer adrress to its address we initialized the first item
        public Node<T> Head { get; private set; }
        //for a pointer to the last item
        public Node<T> Tail { get; private set; }

        // to get the size linked list
        public int Count { get; private set; }

        //constructor for the first, last and count though not needed because it already have a default of null

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }



        //METHODS of the SingleLinkedList


        //Add(T item) - adds an item to the head of the LinkedList and returns the linked list’s size
        public int Add(T NewNode)
        {
            Node<T> NewNodes = new Node<T> { Value = NewNode };
            if (Head == null)
            {
                //this means the linkwed list is empty
                //insert the new node on point the head and tail to the node
                Head = NewNodes;
                Tail = NewNodes;
            }
            else
            {
                //copies the first to the next and adds the incoming to the first address
                NewNodes.NextValue = Head;
                Head = NewNodes;
            }
            Count++;

            return Count;
        }


        // removes the first item in a listList and return void
        public void RemoveFromHead()
        {

            Node<T> CurrentNode = Head;
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Tail = null;
                    Head = null;
                }
                else
                {

                    while (CurrentNode.NextValue != Tail)
                    {
                        CurrentNode = CurrentNode.NextValue;
                    }
                    CurrentNode.NextValue = null;
                    Tail = CurrentNode;
                }
                Count--;
            }

        }

        //Remove(T item) - removes the first occurrence of an item in the linked list, returns true if said item is
        //found and removed or returns false otherwise

        public bool Remove(T item)
        {
            Node<T> previous = null;
            Node<T> CurrentNode = Head;

            while (CurrentNode != null)
            {
                if (CurrentNode.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.NextValue = CurrentNode.NextValue;

                        if (CurrentNode.NextValue == null)
                        {
                            Tail = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFromHead();
                    }
                    return true;
                }

                previous = CurrentNode;
                CurrentNode = CurrentNode.NextValue;

            }
            return false;
        }

        //Check(T item) - checks for a specified item in the linked list. Returns a Boolean

        public bool Check(T item)
        {
            Node<T> CurrentNode = Head;

            while (CurrentNode != null && !CurrentNode.Value.Equals(item))
            {
                CurrentNode = CurrentNode.NextValue;
            }
            if (CurrentNode != null && CurrentNode.Value.Equals(item))
            {
                return true;
            }
            return false;
        }


        //Index(T item) - returns the index of an item or returns -1 if the item isn’t found
        public int Index(T item)
        {
            int count = 1;

            Node<T> CurrentNode = Head;
            while (CurrentNode != null && !CurrentNode.Value.Equals(item))
            {
                CurrentNode = CurrentNode.NextValue;
                count++;
            }
            if (CurrentNode == null)
            {
                return -1;
            }
            return count;
        }

        //Methods needed for stack and queue

        //Adds item to the tail of the LinkedList and returns the linked list’s size

        public int AddToTail(T newNode)
        {
            Node<T> NewNode = new Node<T> { Value = newNode };
            if (Head == null)
            {
                Head = NewNode;
                Tail = NewNode;
            }
            else
            {
                Tail.NextValue = NewNode;
                Tail = NewNode;
            }
            Count++;
            return Count;
        }


        //Remove Methods
        //froms first from stack
        public void RemoveFirst()
        {
            if (Head == null || Count == 0)
            {
                throw new InvalidOperationException("The linkList is empty");
            }
            else
            {
                Head = Head.NextValue;
                Count--;
            }
        }



        //removes the first item and return it
        public T RemoveFirstItem()
        {
            Node<T> newHead = Head;
            if (Head == null || Count == 0)
            {
                throw new InvalidOperationException("LinkedList is empty");
            }
            else
            {
                Head = Head.NextValue;
                Count--;
            }
            return newHead.Value;
        }


        //removes the last element in the linkedlist
        public T ReturnLastItem()
        {
            Node<T> Previous = Head;
            Node<T> Current = Tail;

            return Previous.Value;
        }

        //Ienumerator
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current.NextValue != null)
            {
                yield return current.Value;
                current = current.NextValue;
            }
            yield return current.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
