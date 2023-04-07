using System;
using System.Collections.Generic;
using System.Text;

namespace Handler
{
    public class Email
    {
        public EmailType Type { get; private set; }
        public string Message { get; private set; }

        public Email(EmailType type, string message)
        {
            Type = type;
            Message = message;
        }
    }
}
