using System;
namespace LinkedList
{
    public class HMLinkedList<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;
        private static int count=0;

        public HMLinkedList()
        {
            head = null;
        }

        //Add node in the end of the list.
        public void AddLast(T value)
        {
            //Safety check.
            if (value==null)
            {
                throw new ArgumentNullException(nameof(value), "Thr value you want to add is null.");
            }
            Node newNode = new Node(value);
            //Adding first node to the list.
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                //Reaching the last node and add the new one after it.
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }

        //Add node in the begining of the list.
        public void AddFirst(T value)
        {
            //Safety check.
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Thr value you want to add is null.");
            }

            Node newNode = new Node(value);
            //Adding first node to the list.
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                //Adding the new node befor others.
                newNode.Next = head;
                head = newNode;
            }
            count++;
        }

        //Adding node at a specific position.
        public void AddAtPosition(T value,int position)
        {
            //Safety check.
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "The value you want to add is null.");
            }
            if (position<0||position>Count())
            {
                throw new ArgumentOutOfRangeException(nameof(value), "The position you want to add in it is Out Of Range.");

            }

            Node newNode = new Node(value);

            //position 0 means adding at the begining.
            if (position == 0)
            {
                AddFirst(value);
                return;
            }

            int index = 0;
            Node current = head;

            //Reaching the node befor the node at wanted position.
            while (index != position-1)
            {
                current = current.Next;
                index++;
            }

            //linking new node with nodes after posuition
            //And the nodes beore position with the nwe one.
            newNode.Next = current.Next;
            current.Next = newNode;
            count++;
        }

        //Remove node from the end.
        public void RemoveLast()
        {
            //Safety check
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return;
            }
                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            count--;
        }

        //Remove node from the Begining.
        public void RemoveFirst() 
        {
            //Safety check
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return;
            }
            Node current = head;
            head = current.Next;
            count--;
        }
        
        //Remove node from a specific position.
        public void RemoveAtPosition(int position)
        {
            //Safety check
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return;
            }
            if (position < 0 || position > Count())
            {
                throw new ArgumentOutOfRangeException(nameof(position), "The position you want to add in it is Out Of Range.");

            }

            //position 0 means Removing from the begining.
            if (position == 0)
            {
                RemoveFirst();
                return;
            }

            int index = 0;
            Node current = head;
            while (index != position - 1)
            {
                current = current.Next;
                index++;
            }
            current.Next = current.Next.Next;
            count--;
        }

        //Remove a node by its value.
        public void RemoveByValue(T value)
        {
            //Safety check
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "The value you want to add is null.");
            }
            if (!IsContain(value)||IsEmpty())
            {
                Console.WriteLine("The List does not contain this value or the list is empty!");
                return;
            }

            Node current = head;
            while (current != null)
            {
                //Remove the first node
                if (current.Data.Equals(value))
                {
                    head = current.Next;
                    count--;
                    break;
                }
                //Remove the second node and above
                else if (current.Next.Data.Equals(value))
                {
                    current.Next = current.Next.Next;
                    count--;
                    break;
                }
                current = current.Next;
            }
        }

        //Number of nodes
        public int Count() => count;

        //Searching method
        public bool IsContain(T value)
        {
            //Safety check
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "The value you want to add is null.");
            }
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
                return false;
            }

            Node current = head;
            while (current!= null)
            {
                if (current.Data.Equals(value))
                    return true;

                current = current.Next;
            }
            return false;
        }
        public bool IsEmpty() => count == 0 ? true : false;
        public void PrintLinkedList(HMLinkedList<T> List)
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
                return;
            }

            Node current = List.head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

    }

}
