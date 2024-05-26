using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class CustomerQueue
    {
        private readonly int maxSize = 5;
        private Customer[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems = 0;

        public CustomerQueue()
        {
            store = new Customer[maxSize];
        }

        public Customer GetCustomerAt(int index)
        {
            if (index < 0 || index >= numItems)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return store[(head + index) % maxSize];
        }
       
        public void Enqueue(Customer customer)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Queue is full");
            }

            store[tail] = customer;
            tail += 1;
            if (tail == maxSize)
            {
                tail = 0;
            }
            numItems += 1;
        }
        
        public Customer Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            Customer headItem = store[head];
            head = head + 1;
            if (head == maxSize)
            {
                head = 0;
            }
            numItems = numItems - 1;
            return headItem;
        }

        public Customer Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return store[head];
        }

        public bool IsEmpty() => numItems == 0;
        public bool IsFull() => numItems == maxSize;
        public int Count => numItems;
        
        public float TotalAmountOwed()
        {
            float total = 0;
            for (int i = 0; i < numItems; i++)
            {
                total += store[(head + i) % maxSize].AmountOwed;
            }
            return total;
        }

        public Customer MaxDebtCustomer()
        {
            if (IsEmpty())
            {
                return null;
            }

            Customer maxDebtCustomer = store[head];
            int current = head;
            for (int i = 0; i < numItems; i++)
            {
                int index = (current + i) % maxSize;
                if (store[index].AmountOwed > maxDebtCustomer.AmountOwed)
                {
                    maxDebtCustomer = store[index];
                }
            }
            return maxDebtCustomer;
        }
    }
}