using System;

namespace GenericClasses        
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //singleList test cases
            LinkedList<string> strings = new LinkedList<string>();
            strings.Add("A");
            strings.Add("C");
            strings.Add("B");
            strings.Add("C");
            strings.Add("D");
            strings.Add("C");
            strings.Add("E");
            strings.Add("F");
            Console.WriteLine($"returns true if present and false if absent: {strings.Check("F")}");
            Console.WriteLine($"The item removed from the linkedlist is firstOccurance: {strings.Remove("C")}");
            Console.WriteLine($"the index of D is : {strings.Index("D")}");


            foreach (var item in strings)
            {
                Console.WriteLine($"The items present in the singlelinkedlist is: {item}");
            }
            Console.WriteLine("************************************************");
            Console.WriteLine("*************");


            //Stack TestCase

            Stack<string> stack = new Stack<string>();
            stack.Push("Onyinye");
            stack.Push("Esther");
            stack.Push("Uruchi");
            stack.Push("Best");
            stack.Push("John");
            stack.Push("Dozie");
            stack.Push("Stephen");
            stack.Push("Maxwell");
            Console.WriteLine($"the size of the stack before popping : {stack.Size()}");

            Console.WriteLine($"The item popped from the stack is :{stack.Pop()}");
            Console.WriteLine($"the size of the stack after poping : {stack.Size()}");
            Console.WriteLine($"return true if is not IsEmpty and false if it IsEmpty: {stack.IsEmpty()}");
            foreach (var item in stack)
            {
                Console.WriteLine($"The items of the stack is : {item}");
            }

            Console.WriteLine("*********");
            Console.WriteLine("*******************************");


            //Queue Test Cases
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amanda");
            queue.Enqueue("Jane");
            queue.Enqueue("Louis");
            queue.Enqueue("Faith");
            queue.Enqueue("Udoka");
            queue.Enqueue("Chizaram");
            Console.WriteLine($"The item removed : from the queue is: {queue.Dequeue()}");

            Console.WriteLine($"The size of the queue is: {queue.Size()}");
            Console.WriteLine($"Returns True if the queue is not empty and false if it is empty: {queue.QueueIsEmpty()}");
            foreach (var item in queue)
            {
                Console.WriteLine($"The items in the queue is : {item}");
            }
            Console.ReadLine();
        }
    }
}
