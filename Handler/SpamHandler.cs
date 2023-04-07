using System;
using System.Collections.Generic;
using System.Text;

namespace Handler
{
    public class SpamHandler : Handler
    {
        public SpamHandler(Handler successor) : base(successor)
        {

        }
        public override void HandleRequest(Email email)
        {
            if (email.Type == EmailType.Spam)
            {
                Console.WriteLine("Spam Handler is handing the following message..");
                Console.WriteLine("Deleting the following email...");
                Console.WriteLine(email.Message);
                Console.WriteLine();
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(email);
            }
        }
    }

    
}
