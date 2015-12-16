using System;

namespace _03.GenericList
{
    public static class GenericListExtensions
    {
        public static T Min<T>(this GenericList<T> list) where T : IComparable<T>
        {
            var minItem = list[0];
            for (var i = 1; i < list.Size(); i++)
            {
                if (list[i].CompareTo(minItem) < 0)
                {
                    minItem = list[i];
                }
            }

            return minItem;
        }

        public static T Max<T>(this GenericList<T> list) where T : IComparable<T>
        {
            var maxItem = list[0];
            for (var i = 1; i < list.Size(); i++)
            {
                if (list[i].CompareTo(maxItem) > 0)
                {
                    maxItem = list[i];
                }
            }

            return maxItem;
        }
    }
}
