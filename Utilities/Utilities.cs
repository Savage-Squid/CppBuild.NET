using System.Collections.Generic;

namespace CppBuild.Utilities
{
    public static class Utilities
    {
        /// <summary>
        /// Adds the range of the items to the hash set.
        /// </summary>
        /// <typeparam name="T">The item type.</typeparam>
        /// <param name="source">The hash set to modify.</param>
        /// <param name="items">The items collection to append.</param>
        public static void AddRange<T>(this HashSet<T> source, IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                source.Add(item);
            }
        }
    }
}