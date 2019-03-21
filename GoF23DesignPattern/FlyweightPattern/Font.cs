using System;

namespace FlyweightPattern
{
    /// <summary>
    /// 字体
    /// </summary>
    public class Font : object //(12bytes+8bytes=20bytes)*n
    {
        private string fontName; // 4bytes
        private int size;//4bytes
        private Color color; //4bytes

        public Font(string name, int size, Color color)
        {
            this.fontName = name;
            this.size = size;
            this.color = color;
        }

        public override bool Equals(object obj)
        {
            var font = obj as Font;
            return font != null &&
                   fontName == font.fontName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Color
    {
        public static string Read = "read";
        public static string Orange = "orange";
    }
}