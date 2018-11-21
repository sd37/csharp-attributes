using System;

namespace ContactWriter
{
    [AttributeUsage(AttributeTargets.Class)]
    class DefaultColorAttribute : Attribute
    {
        public ConsoleColor Color { get; set; } = ConsoleColor.Yellow;
    }
}
