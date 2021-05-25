using System;

namespace CourseLib
{
    public class TicketsAreOverException : Exception
    {
        public TicketsAreOverException(string message)
        : base(message)
        { }
    }
}
