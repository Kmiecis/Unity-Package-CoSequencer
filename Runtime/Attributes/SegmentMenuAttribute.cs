using System;

namespace Common.Coroutines
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SegmentMenuAttribute : Attribute
    {
        public readonly string menuPath;
        public readonly string fileName;

        public SegmentMenuAttribute(string menuPath, string fileName)
        {
            this.menuPath = menuPath;
            this.fileName = fileName;
        }

        public SegmentMenuAttribute(string fileName) :
            this(null, fileName)
        {
        }

        public SegmentMenuAttribute() :
            this(null, null)
        {
        }
    }

    public static class SegmentMenuAttributeExtensions
    {
        public static string GetMenuPathOrDefault(this SegmentMenuAttribute self, string defaultValue = null)
        {
            return (self == null || self.menuPath == null) ? defaultValue : self.menuPath;
        }

        public static string GetFileNameOrDefault(this SegmentMenuAttribute self, string defaultValue = null)
        {
            return (self == null || self.fileName == null) ? defaultValue : self.fileName;
        }
    }
}