using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RealDB.src
{
    public class EventHandler
    {
        private readonly string _database = "DATABASE";
        private readonly string _table = "TABLE";
        private readonly string _invalid = "INVALID SYNTAX";
        private readonly string _create = "CREATE";

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
            if (input.Length == 3)
            {
                if (input[1] == _database)
                {
                    
                }
                main.errorHandler.ReturnError(_invalid);
            }

            //  0       1       2     3      4    5
            // CREATE DATABASE NAME CREATE TABLE NAME
            if (input.Length > 4)
            {
                if (input[0] == _create && input[1] == _database)
                {
                    if (input[3] == _create && input[4] == _table)
                    {
                        CreateDatabase(input[2], input[5], true);
                    }
                }
            }
            main.errorHandler.ReturnError(_invalid);


        }

        public void CreateDatabase(string name, string tableName,  bool andTable)
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

                if (andTable)
                    CreateATable();
            }
        }

        public void CreateATable()
        {
            Console.WriteLine("ASD");
        }

        public void CreateTable(string database, string name)
        {
            Console.WriteLine("ASD");

            string path = Directory.GetCurrentDirectory();
            string databaseFolder = Path.GetFullPath(Path.Combine(path, database));
            string file = (name + ".rdp");

            string tempPath = Path.GetFullPath(Path.Combine(databaseFolder, file));

            if (File.Exists(tempPath))
            {
                Console.WriteLine(name);
            }
            else
            {
                File.Create(tempPath);
                Console.WriteLine("FILE CREATED");
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
