using System;

namespace ContactWriter
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    class IndentAttribute : Attribute {}
}
