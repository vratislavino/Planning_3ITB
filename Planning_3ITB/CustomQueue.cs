using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planning_3ITB
{
    internal class CustomQueue<T>
    {
        List<T> list = new List<T>();

        public int Count => list.Count;

        public void Enqueue(T item)
        {
            list.Add(item);
        } 

        public T Dequeue()
        {
            if (list.Count == 0)
                return default(T);
            var obj = list.First();
            list.Remove(obj);
            return obj;
        }

        public T Get(int index)
        {
            if(index < 0 || index >= list.Count)
                return default(T);
            return list[index];
        }
    }
}
