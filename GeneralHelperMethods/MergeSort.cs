using System;
using System.Collections.Generic;

namespace GeneralHelperMethods
{
    public class MergeSort<T> : ISort<T>  where T : IComparable<T>
    {
        public override void SortList()
        {
            list = RecursiveSplitter(list);
        }
        public override void SortList(List<T> l)
        {
            list = l;
            list = RecursiveSplitter(list);
        }

        public List<T> RecursiveSplitter(List<T> l)
        {
            if (l.Count == 1)
            {
                return l;
            }
            int midPoint = l.Count / 2;

            List<T> left = CopyOfRange(l, 0, midPoint), right = CopyOfRange(l, midPoint, l.Count);

            return Merger(RecursiveSplitter(left), RecursiveSplitter(right));
        }

        public List<T> Merger(List<T> list1, List<T> list2)
        {
            List<T> output = new List<T>();

            List<T> totalList = new List<T>();
            totalList.AddRange(list1);
            totalList.AddRange(list2);

            output.Add(totalList[0]);

            for (int i = 1; i < totalList.Count; i++)
            {
                if (totalList[i].CompareTo(totalList[i - 1]) > 0)
                {
                    output.Add(totalList[i]);
                }
                else
                {
                    output.Insert(0, totalList[i]);
                }
            }
            return output;
        }
    }
}