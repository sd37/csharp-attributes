using System;

namespace ContactWriter
{
    [AttributeUsage(AttributeTargets.Property)]
    class DisplayAttribute : Attribute
    {
        public DisplayAttribute(string label, ConsoleColor color = ConsoleColor.White)
        {
            Label = label ?? throw new ArgumentNullException(nameof(label));
            Color = color;
        }

        public string Label { get; }

        public ConsoleColor Color { get; }
    }
}
