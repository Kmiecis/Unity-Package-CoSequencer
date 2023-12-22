using System;
using System.Linq;
using System.Reflection;
using Common.Coroutines;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines
{
    [CustomEditor(typeof(CoSequence))]
    public class CoSequenceEditor : Editor
    {
        private readonly Type SubclassType = typeof(Segment);

        private int _count;
        
        private CoSequence Script
            => (CoSequence)target;
        
        private void ShowAddMenu()
        {
            var menu = new GenericMenu();
            
            var added = 0;
            
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            for (int i = 0; i < assemblies.Length; ++i)
            {
                var assembly = assemblies[i];
                
                var types = assembly.FindTypes(t => t.IsSubclassOf(SubclassType) && !t.IsAbstract);
                
                if (types.Any())
                {
                    if (added > 0)
                    {
                        menu.AddSeparator(string.Empty);
                    }
                    added += 1;
                }
                
                foreach (var type in types)
                {
                    var attribute = type.GetCustomAttribute<SegmentMenuAttribute>();
                    var menuPath = attribute.GetMenuPathOrDefault("Custom");
                    var fileName = attribute.GetFileNameOrDefault(type.Name);

                    var path = $"{menuPath}/{fileName}";
                
                    menu.AddItem(new GUIContent(path), false, OnMenuAdd, type);
                }
            }
            
            menu.ShowAsContext();
        }

        private void OnMenuAdd(object type)
        {
            var instance = (Segment)Activator.CreateInstance((Type)type);
            
            Script.AddSegment(instance);

            _count = Script.SegmentCount;
        }

        private void CheckSequenceChange()
        {
            var current = Script.SegmentCount;
            if (current > _count)
            {
                Script.RemoveLastSegment();
                
                ShowAddMenu();
            }
            else
            {
                _count = current;
            }
        }
        
        private void OnEnable()
        {
            _count = Script.SegmentCount;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            CheckSequenceChange();
        }
    }
}