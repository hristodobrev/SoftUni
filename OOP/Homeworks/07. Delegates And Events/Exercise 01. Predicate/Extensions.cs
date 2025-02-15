﻿namespace Exercise_01
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static T FirstOrDefault<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            foreach (T element in collection)
            {
                if (condition(element))
                {
                    return element;
                }
            }

            return default(T);
        }
    }
}
