using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;

namespace CommonEditor.Coroutines
{
    internal static class Extensions
    {
        #region AppDomain
        public static IEnumerable<Type> FindTypes(this AppDomain self, Predicate<Type> match)
        {
            foreach (var assembly in self.GetAssemblies())
            {
                foreach (var type in assembly.FindTypes(match))
                {
                    yield return type;
                }
            }
        }
        #endregion

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

        #region SerializedProperty
        public static IEnumerable<SerializedProperty> GetChildren(this SerializedProperty self)
        {
            var iterator = self.Copy();
            var end = iterator.GetEndProperty();

            if (iterator.NextVisible(true))
            {
                do
                {
                    if (SerializedProperty.EqualContents(iterator, end))
                    {
                        break;
                    }
                    yield return iterator;
                }
                while (iterator.NextVisible(false));
            }
        }

        public static object GetValue(this SerializedProperty self)
        {
            var sanitizedPath = self.propertyPath.Replace(".Array.data[", "[");
            object result = self.serializedObject.targetObject;

            var elements = sanitizedPath.Split('.');
            foreach (var element in elements)
            {
                if (element.Contains("["))
                {
                    result = GetValueFromList(result, element);
                }
                else
                {
                    result = GetValueFromType(result, element);
                }
            }
            return result;
        }

        private static object GetValueFromList(object source, string subpath)
        {
            var indexBegin = subpath.IndexOf("[");
            var indexEnd = subpath.IndexOf("]");
            var strIndex = subpath.Substring(indexBegin + 1, indexEnd - (indexBegin + 1));
            var index = int.Parse(strIndex);

            var name = subpath.Substring(0, indexBegin);

            var list = GetValueFromType(source, name) as System.Collections.IList;
            if (list != null)
            {
                return list[index];
            }
            return null;
        }

        private static object GetValueFromType(object source, string name)
        {
            var type = source.GetType();
            while (type != null)
            {
                var field = type.GetField(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                if (field != null)
                {
                    return field.GetValue(source);
                }

                var property = type.GetProperty(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (property != null)
                {
                    return property.GetValue(source, null);
                }

                type = type.BaseType;
            }
            return null;
        }
        #endregion

        #region Type
        public static bool HasInterface(this Type self, Type target)
        {
            var interfaces = self.GetInterfaces();
            foreach (var item in interfaces)
            {
                if (Equals(item, target))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}