using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_500W_Stack_Q
{
     public class PersonStack
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
        public static List<PersonStack> PopLast(List<PersonStack> person)
        {
            List<PersonStack> popedPerson = new List<PersonStack>();
            for (int i = 0; i < person.Count-1; i++)
            {
                popedPerson.Add(person[i]);
            }

            return popedPerson;
            
        }


        public static string PopedLast(List<PersonStack> person)
        {
            string popedLast = person[person.Count()-1].FullName;
            List<PersonStack> popedPerson = new List<PersonStack>();
            for (int i = 0; i < person.Count - 1; i++)
            {
                popedPerson.Add(person[i]);
            }

            return popedLast;

        }

    }
}
