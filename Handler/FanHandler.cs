using System;
using System.Collections.Generic;
using System.Text;

namespace Handler
{
    public class FanHandler : Handler
    {
        public FanHandler(Handler successor) : base(successor)
        {

        }
        public override void HandleRequest(Email email)
        {
            if (email.Type == EmailType.Fan)
            {
                Console.WriteLine("Fan Handler is handling the following message ...");
                Console.WriteLine("Sending to the CEO ...");
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

