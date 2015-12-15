using System;
using System.Collections.Generic;

namespace _01.CustomLinqExtensionMethods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(
          this IEnumerable<T> collection, Predicate<T> predicate)
        {
            var result = new List<T>();
            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    result.Add(element);
                }
            }

            return result;
        }

        public static TResult Maximum<TSource, TResult>(
            this IEnumerable<TSource> collection, Func<TSource, TResult> function)
            where TResult : IComparable<TResult>
        {
            var result = new List<TResult>();
            foreach (var element in collection)
            {
                result.Add(function(element));
            }

            var max = result[0];
            for (var i = 1; i < result.Count; i++)
            {
                if (result[i].CompareTo(max) > 0)
                {
                    max = result[i];
                }
            }

            return max;
        }
    }
}
