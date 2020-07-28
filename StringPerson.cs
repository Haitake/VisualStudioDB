using System;
namespace VisualStudioDB
{
    public class StringPerson
    {
        string person;
        public StringPerson(Person person)
        {
            this.person = String.Format("Name : {0}, Age: {1} ",  person.name, person.age.ToString());
        }
    }
}
