using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _03.GenericSwapMethodString
{
    public class Box<T>
    {
        public List<T> Items { get; set; }

        public Box()
        {
            this.Items = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = temp;
        }
    }
}
