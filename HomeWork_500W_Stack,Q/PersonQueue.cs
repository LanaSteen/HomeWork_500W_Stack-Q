using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_500W_Stack_Q
{
    internal class PersonQueue
    {


        public string FirstName { get; set; }   //properties
        public string LastName { get; set; }
        public string FullName    //property with methods funqtion
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string GetFullName()   // method
        {
            return FirstName + " " + LastName;
        }

        public static List<PersonQueue> PopFirst(List<PersonQueue> person)
        {
            List<PersonQueue> popedPerson = new List<PersonQueue>();
            for (int i = 1; i < person.Count; i++)
            {
                popedPerson.Add(person[i]);
            }

            return popedPerson;

        }

        public static string Dequeue(List<PersonQueue> person)
        {
            string removedPerson = person[0].FullName;
            List<PersonQueue> popedPerson = new List<PersonQueue>();
            List <PersonQueue> decuedPerson = new List<PersonQueue>(person.Count()-1);

            for (int i = 1; i < person.Count; i++)
            {
                decuedPerson.Add(person[i]);
            }

            return removedPerson;

        }

        
    }
}
