using System;

namespace Simple.CaseConverter
{
    /// <summary>
    /// Represents errors that occur during case conversion.
    /// </summary>
    [Serializable]
    public class CaseConverterException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseConverterException"/> class.
        /// </summary>
        public CaseConverterException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseConverterException"/> class
        /// with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public CaseConverterException(string message)
            : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseConverterException"/> class
        /// with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="inner">The exception that is the cause of the current exception.</param>
        public CaseConverterException(string message, Exception inner)
            : base(message, inner) { }
    }
}