using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RealDB.src.Syntax;

namespace RealDB.src
{
    public class input : Commands
    {
        private main main;
        public input(main main)
        {
            this.main = main;
        }
        

        public void SplitQuerry(string querry)
        {

            string[] words = querry.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            if (words.Length <= 0)
                main.errorHandler.ReturnError("No querry inserted, type help for a list of commands");

            ReadQuerry(words);
        }

        public void ReadQuerry(string[] commands)
        {

            string start = commands[0];

            if(start == "SELECT")
            {
                main.handler.SELECT(commands);
            }
            else if (start == "INSERT")
            {
                
            }
            else if(start == "DELETE")
            {

            }
            else if(start == "VIEW")
            {

            }
            else if(start == "CREATE")
            {
                main.handler.Create(commands);
            }
            else
            {
                main.errorHandler.ReturnError("INVALID SYNTAX");
            }
                    
        }
    }
}
