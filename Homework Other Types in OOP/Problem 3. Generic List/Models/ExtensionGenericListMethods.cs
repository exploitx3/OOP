using System;
using System.Runtime.InteropServices.ComTypes;

namespace Problem_3.Generic_List.Models
{
    public static class ExtensionGenericListMethods
    {
        public static T Min<T>(this GenericList<T> list) where T : IComparable
        {
            T minElement = list.ElementAtIndex(0);
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAtIndex(i).CompareTo(minElement) < 0)
                {
                    minElement = list.ElementAtIndex(i);
                }
            }
            return minElement;
        }
        public static T Max<T>(this GenericList<T> list) where T : IComparable
        {
            T maxElement = list.ElementAtIndex(0);
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAtIndex(i).CompareTo(maxElement) > 0)
                {
                    maxElement = list.ElementAtIndex(i);
                }
            }
            return maxElement;
        }
    }
}