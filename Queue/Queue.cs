using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        Queue<int> queue = new Queue<int>();
        public Queue()
        {

        }
        public void Add(int value)
        {
            queue.Enqueue(value);
        }
        public void Delete()
        {
            queue.Dequeue();
        }
        public int Amount()
        {
           return queue.Count();
        }
        public int Max()
        {
            return queue.Max();
        }
        public int Min()
        {
            return queue.Min();
        }
        public string Find(int value)
        {
            if (queue.Contains(value))
                return value + " was found";
            else return value + " could not be found";
        }
        public Queue<int> PrintAll()
        {
            return queue;
        }
    }
}
