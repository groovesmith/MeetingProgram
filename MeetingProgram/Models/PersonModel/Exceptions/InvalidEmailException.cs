using System;
using System.Runtime.Serialization;

namespace MeetingProgram.Models.PersonModel.Exceptions
{
    [Serializable]
    internal class InvalidEmailException : Exception
    {
        public InvalidEmailException() : base("The Email is not Valid")
        {

        }
        public InvalidEmailException(string msg) : base(msg)
        {

        }
        public InvalidEmailException(string msg, Exception inner) : base(msg, inner)
        {

        }
    }
}