﻿namespace Collection_Hierarchy
{
    using System.Linq;

    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        public virtual T Remove()
        {
            var lastElement = this.Data.Last();
            this.Data.RemoveAt(this.Data.Count - 1);
            return lastElement;
        }

        public override int Add(T element)
        {
            this.Data.Insert(0,element);
            return 0;
        }
    }
}
