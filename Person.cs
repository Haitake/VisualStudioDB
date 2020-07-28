using System;
using SQLite;
namespace VisualStudioDB
{
    [Table("Person")]
    public class Person
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public Person()
        {
            
        }


    }
}
