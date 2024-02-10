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
        public static object GetValue(this SerializedProperty self)
        {
            var sanitizedPath = self.propertyPath.Replace(".Array.data[", "[");
            object result = self.serializedObject.targetObject;

            var elements = sanitizedPath.Split('.');
            foreach (var element in elements)
            {
                if (element.Contains("["))
                {
                    var elementName = element.Substring(0, element.IndexOf("["));
                    var strIndex = element.Substring(element.IndexOf("[")).Replace("[", string.Empty).Replace("]", string.Empty);
                    var index = int.Parse(strIndex);
                    result = GetValueFromEnumerable(result, elementName, index);
                }
                else
                {
                    result = GetValueFromType(result, element);
                }
            }
            return result;
        }

        private static object GetValueFromEnumerable(object source, string name, int index)
        {
            var enumerable = GetValueFromType(source, name) as System.Collections.IEnumerable;
            foreach (var value in enumerable)
            {
                if (index-- == 0)
                {
                    return value;
                }
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