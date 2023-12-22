using System;
using System.Collections.Generic;
using System.Reflection;

namespace CommonEditor.Coroutines
{
    internal static class Extensions
    {
        #region Assembly
        public static IEnumerable<Type> FindTypes(this Assembly self, Predicate<Type> match)
        {
            foreach (var type in self.GetTypes())
            {
                if (match(type))
                {
                    yield return type;
                }
            }
        }
        #endregion
    }
}