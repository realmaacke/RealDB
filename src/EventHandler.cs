using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDB.src
{
    public class EventHandler
    {
        public main main;
        string dbPath;
        public EventHandler(main main)
        {
            this.main = main;
            dbPath = main.DATABASEDIRECTORY;
            Directory.SetCurrentDirectory(dbPath);
        }

        // TODO CREATE TABLE WHEN SELECT
        #region Create

        public void Create(string[] input)
        {
            if(input.Length >= 3)
            {
                if(input.Length == 3)
                {
                    if (input[1] == "DATABASE")
                    {
                        CreateDatabase(input[2]);
                    }
                    main.errorHandler.ReturnError("INVALID SYNTAX");
                }
                
                if(input.Length == 6)
                {
                    if (input[4] == "CREATE" && input[5] == "TABLE")
                    {
                        CreateTable(input[2], input[6]);
                    }
                }
                main.errorHandler.ReturnError("INVALID SYNTAX");
            }
            main.errorHandler.ReturnError("INVALID SYNTAX");

        }

        public string CreateDatabase(string name)
        {
            string path = Directory.GetCurrentDirectory();
            string database = Path.GetFullPath(Path.Combine(path, name));

            if (Directory.Exists(database))
            {
                main.errorHandler.ReturnError("Database with that name already exists");
            }
            else
            {
                Directory.CreateDirectory(database);
                main.errorHandler.ReturnError("Database Succesfully Created");
            }

            return database;
        }

        public void CreateTable(string database, string name)
        {
            string path = Directory.GetCurrentDirectory();
            string Table = Path.GetFullPath(Path.Combine(path, name));
            if (File.Exists(name + ".rdp"))
            {
                
            }
            
        }

        #endregion 
        #region Select

        public void SELECT(string[] commands)
        {

        }   

        #endregion
        #region Insert
        #endregion
        #region Delete
        #endregion
    }
}
