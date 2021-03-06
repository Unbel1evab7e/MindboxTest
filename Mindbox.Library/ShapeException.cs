using System;
using System.Diagnostics.CodeAnalysis;

namespace Mindbox.Library
{
    public class ShapeException : Exception
    {
        public Type ShapeType { get; set; }

        public ShapeException(string message, Type shapeType) : base(message)
        {
            ShapeType = shapeType;
        }
    }
}