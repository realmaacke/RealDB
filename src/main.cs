using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDB.src
{
    public class main
    {
        public Manager Manager;
        public input input;
        public EventHandler handler;
        public ErrorHandler errorHandler;

        public readonly string DATABASEDIRECTORY = "D:\\projects\\Databases\\RealDB\\db\\";
        public main()
        {
            input = new input(this);
            handler = new EventHandler(this);
            errorHandler = new ErrorHandler(this);


            Manager = new Manager(input, handler, errorHandler);
            start();
        }

        public void start()
        {
            Console.Write("<RealDB> : ");
            var input = Console.ReadLine();
            Manager.input.SplitQuerry(input);

            Console.ReadKey();

        }
    }
}
