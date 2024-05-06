using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Reponsibility
{
    public abstract class Handler : IHandler
    {
        protected IHandler? _next;

        public Handler SetNextHandler(Handler next)
        {
            this._next = next;
            return next;
        }
        public abstract void Handle(int choice);

        protected void HandleNext(int choice)
        {
            if (_next == null)
            {
                Console.WriteLine("Error in selection");
            }
            else
            {
                this._next.Handle(choice);
            }
        }
    }
}
