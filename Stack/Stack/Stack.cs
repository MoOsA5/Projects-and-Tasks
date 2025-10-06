using System;


namespace Stack
{
    class Stack
    {
        const int capacity = 10;
        int[] data = new int[capacity];
        int top;

        public Stack()
        {
            top = 0;
        }
        public void Push(int value)
        {
            if (top < capacity)
            {
                data[top] = value;
                top++;
            }
        }
        public int Pop()
        {
            if (!IsEmpty)
            {
                top--;
                return data[top];
            }
            else return 0;
        }
        private bool IsEmpty => top == 0;
        public int Top => top;
    }
}
