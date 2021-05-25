using System;

namespace CourseLib
{
    public class PosterIsEmptyException : Exception
    {
        public PosterIsEmptyException(string message)
        : base(message)
        {}
    }
}
