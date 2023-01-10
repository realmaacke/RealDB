using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDB.src
{
    public class ErrorHandler
    {
        private main main;
        public ErrorHandler(main main)
        {
            this.main = main;
        }


        public void ReturnError(string error)
        {
            Console.WriteLine("<RealDB> " + error);

            main.start();
        }
    }
}
