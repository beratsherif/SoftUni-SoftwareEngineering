using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Box
{
    //public class Box<T>
    //{
    //    private List<T> list;

    //    public Box()
    //    {
    //        list = new List<T>();
    //    }

    //    public int Count
    //    {
    //        get { return this.list.Count; }
    //    }

    //    public void Add(T element)
    //    {
    //        list.Insert(Count,element);
    //    }

    //    public T Remove()
    //    {
    //        T elementToRemove = list[Count - 1];
    //        list.RemoveAt(Count - 1);
    //        return elementToRemove;
    //    }
    //}

    public class Box<T>
    {
        private Stack<T> list;
        public Box()
        {
            list = new Stack<T>();
        }
        public int Count
        {
            get { return list.Count; }
        }

        public void Add(T element)
        {
            list.Push(element);
        }

        public T Remove()
        {
            T currElement = list.Pop();
            return currElement;
        }
    }

}
