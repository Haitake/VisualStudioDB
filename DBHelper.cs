using System;
using SQLite;
using System.Collections.Generic;

namespace VisualStudioDB
{
    public class DBHelper
    {
        readonly SQLiteConnection sQLiteConnection;
        

        public DBHelper(string dbPath)
        {
            sQLiteConnection = new SQLiteConnection(dbPath);
            sQLiteConnection.CreateTable<Person>();
           if(sQLiteConnection.Table<Person>().Count() == 0)
            {
                var personone = new Person();
                personone.name = "Pepa";
                personone.age = 35;
                sQLiteConnection.Insert(personone);
                var persontwo = new Person();
                persontwo.name = "Karel";
                persontwo.age = 55; ;
                sQLiteConnection.Insert(persontwo);    

            }

        }

        public List<Person> Read()
        {
            return sQLiteConnection.Table<Person>().ToList();

        }

    }
}
