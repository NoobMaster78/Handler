using System;
using System.Collections.Generic;
using System.Text;

namespace Handler
{
    public abstract class Handler
    {
        protected Handler _successor;

        public Handler(Handler successor)
        {
            _successor = successor;
        }

        public abstract void HandleRequest(Email email);
    }
}
