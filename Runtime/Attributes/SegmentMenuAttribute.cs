using System;

namespace Common.Coroutines
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SegmentMenuAttribute : Attribute
    {
        public readonly string fileName;
        public readonly string menuPath;
        public readonly int group;

        public SegmentMenuAttribute(
            string fileName = null,
            string menuPath = SegmentPath.Custom,
            int group = SegmentGroup.Custom
        )
        {
            this.menuPath = menuPath;
            this.fileName = fileName;
            this.group = group;
        }
    }

    public static class SegmentMenuAttributeExtensions
    {
        public static string GetMenuPathOrDefault(this SegmentMenuAttribute self, string defaultValue = SegmentPath.Custom)
        {
            return (self == null || self.menuPath == null) ? defaultValue : self.menuPath;
        }

        public static string GetFileNameOrDefault(this SegmentMenuAttribute self, string defaultValue = null)
        {
            return (self == null || self.fileName == null) ? defaultValue : self.fileName;
        }

        public static int GetGroupOrDefault(this SegmentMenuAttribute self, int defaultValue = SegmentGroup.Custom)
        {
            return (self == null) ? defaultValue : self.group;
        }
    }
}