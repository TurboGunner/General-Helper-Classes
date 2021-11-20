using System;
using System.Collections.Generic;

namespace GeneralHelperMethods
{
    public abstract class ISort<T> where T : IComparable<T>
    {
        public List<T> list { get; set; }
        public ISort() {
            list = new List<T>();
        }

        public ISort(params T[] items)
        {
            foreach(T item in items)
            {
                list.Add(item);
            }
        }

        public string OutputList()
        {
            string output = "";
            foreach(T item in list)
            {
                output += item.ToString() + "\n";
            }
            return output;
        }
        public List<T> CopyOfRange(List<T> l, int start, int end)
        {
            List<T> output = new List<T>();
            for (int i = start; i < end; i++)
            {
                output.Add(l[i]);
            }
            return output;
        }

        public abstract void SortList();
        public abstract void SortList(List<T> list);
    }
}