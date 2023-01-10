using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDB.src
{
    public class Manager
    {
        public input input;
        public EventHandler handler;
        public ErrorHandler errorHandler;
        public Manager(input input, EventHandler eventHandler, ErrorHandler errorHandler)
        {
            this.input = input;
            this.handler = eventHandler;
            this.errorHandler = errorHandler;
        }
    }
}
