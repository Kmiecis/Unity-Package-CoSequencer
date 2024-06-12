using Common.Coroutines;
using System.Linq;
using System;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines.Segments
{
    public abstract class ChoiceSegmentDrawer : PropertyDrawer
    {
        protected class Entry
        {
            public string name;
            public Type type;
            public Func<ISegment> constructor;

            public static Entry Create<T>(string name, Func<T> constructor)
                where T : class, ISegment
            {
                return new Entry
                {
                    name = name,
                    type = typeof(T),
                    constructor = constructor
                };
            }
        }

        private Entry[] _entries;

        protected abstract Entry[] CreateEntries();

        protected Entry[] GetEntries()
        {
            if (_entries == null)
                _entries = CreateEntries();
            return _entries;
        }

        protected string[] GetNames()
            => GetEntries().Select(e => e.name).ToArray();

        protected Type[] GetTypes()
            => GetEntries().Select(e => e.type).ToArray();

        protected Func<ISegment>[] GetConstructors()
            => GetEntries().Select(e => e.constructor).ToArray();

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var drawIndex = ReadSegmentIndex(property);
            var choiceIndex = DrawPopup(position, drawIndex);
            if (choiceIndex != drawIndex)
                UpdateSegmentValue(property, choiceIndex);

            var segmentProperty = GetSegmentProperty(property);
            EditorGUI.PropertyField(position, segmentProperty, label, true);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var segmentProperty = GetSegmentProperty(property);
            return EditorGUI.GetPropertyHeight(segmentProperty, true);
        }

        private int ReadSegmentIndex(SerializedProperty property)
        {
            var segmentProperty = GetSegmentProperty(property);
            var segment = segmentProperty.GetValue();
            if (segment != null)
            {
                var segmentType = segment.GetType();
                var types = GetTypes();
                for (int i = 0; i < types.Length; ++i)
                {
                    var type = types[i];
                    if (type == segmentType)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private int DrawPopup(Rect position, int index)
        {
            const float WIDTH = 20.0f;
            position.height = EditorGUIUtility.singleLineHeight;
            position.x += position.width - WIDTH;
            position.width = WIDTH;

            var names = GetNames();
            var result = EditorGUI.Popup(position, index, names);
            return Math.Max(result, 0);
        }

        private void UpdateSegmentValue(SerializedProperty property, int index)
        {
            var constructors = GetConstructors();
            var constructor = constructors[index];
            var segment = constructor();
            var segmentProperty = GetSegmentProperty(property);
            segmentProperty.SetValue(segment);
        }

        private SerializedProperty GetSegmentProperty(SerializedProperty property)
        {
            return property.FindPropertyRelative("_segment");
        }
    }
}