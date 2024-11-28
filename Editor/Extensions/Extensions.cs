using System;
using System.Collections.Generic;
using System.Linq;
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

        #region List
        public static void StableSort<T>(this List<T> self)
            where T : IComparable<T>
        {
            var sorted = self.OrderBy(x => x).ToArray();
            self.Clear();
            self.AddRange(sorted);
        }
        #endregion

        #region SerializedProperty
        public static bool IsInArray(this SerializedProperty self)
        {
            return self.propertyPath.EndsWith("]");
        }

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

        public static void SetValue(this SerializedProperty self, object value)
        {
            var sanitizedPath = self.propertyPath.Replace(".Array.data[", "[");
            object target = self.serializedObject.targetObject;

            var element = (string)null;
            var elements = sanitizedPath.Split('.');
            for (int i = 0; i < elements.Length - 1; ++i)
            {
                element = elements[i];
                if (element.Contains("["))
                {
                    target = GetValueFromList(target, element);
                }
                else
                {
                    target = GetValueFromType(target, element);
                }
            }

            try
            {
                element = elements[elements.Length - 1];
                if (element.Contains("["))
                {
                    SetValueToList(target, element, value);
                }
                else
                {
                    SetValueToType(target, element, value);
                }
            }
            catch (Exception e)
            {
                UnityEngine.Debug.Log(e);
            }
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

        private static void SetValueToList(object target, string subpath, object value)
        {
            var indexBegin = subpath.IndexOf("[");
            var indexEnd = subpath.IndexOf("]");
            var strIndex = subpath.Substring(indexBegin + 1, indexEnd - (indexBegin + 1));
            var index = int.Parse(strIndex);

            var name = subpath.Substring(0, indexBegin);

            var list = GetValueFromType(target, name) as System.Collections.IList;
            if (list != null)
            {
                list[index] = value;
            }
        }

        private static object GetValueFromType(object source, string name)
        {
            var type = source.GetType();
            while (type != null)
            {
                var fieldFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
                var field = type.GetField(name, fieldFlags);
                if (field != null)
                {
                    return field.GetValue(source);
                }

                var propertyFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase;
                var property = type.GetProperty(name, propertyFlags);
                if (property != null)
                {
                    return property.GetValue(source, null);
                }

                type = type.BaseType;
            }
            return null;
        }

        private static void SetValueToType(object target, string name, object value)
        {
            var type = target.GetType();
            while (type != null)
            {
                var fieldFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
                var field = type.GetField(name, fieldFlags);
                if (field != null)
                {
                    field.SetValue(target, value);
                    return;
                }

                var propertyFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase;
                var property = type.GetProperty(name, propertyFlags);
                if (property != null)
                {
                    property.SetValue(target, value);
                    return;
                }

                type = type.BaseType;
            }
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