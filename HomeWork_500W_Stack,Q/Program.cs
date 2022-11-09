using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeWork_500W_Stack_Q.PersonStack;

namespace HomeWork_500W_Stack_Q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> FirstName = new List<string>();
            FirstName.Add("Lana");
            FirstName.Add("John");
            FirstName.Add("Tim");

            /*
            Console.WriteLine("Enter First Names");
            FirstName.Add(Console.ReadLine());
            FirstName.Add(Console.ReadLine());
            FirstName.Add(Console.ReadLine());
            FirstName.Add(Console.ReadLine());*/

            List<string> LastName = new List<string>();
            LastName.Add("Steen");
            LastName.Add("Smith");
            LastName.Add("Lee");
            /*
            Console.WriteLine("Enter Last Names");
            LastName.Add(Console.ReadLine() );
            LastName.Add(Console.ReadLine());
            LastName.Add(Console.ReadLine());
            LastName.Add(Console.ReadLine()); */

            //Stack
            Console.WriteLine("Stack");
            List<PersonStack> personsS = new List<PersonStack>();
            for (int i = 0; i < FirstName.Count; i++)
            {
                PersonStack person = new PersonStack();
                person.FirstName = FirstName[i];
                person.LastName = LastName[i];
                personsS.Add(person);
            }

            List<PersonStack> perS = new List<PersonStack>();
            perS = PersonStack.PopLast(personsS);

            foreach (PersonStack p in perS)
            {
                Console.WriteLine(p.FullName);
            }
            ///PopedLast
            Console.WriteLine();
            Console.WriteLine("Poped Last Object");
            List<PersonStack> personsStack = new List<PersonStack>();

            for (int i = 0; i < FirstName.Count; i++)
            {
                PersonStack person = new PersonStack();
                person.FirstName = FirstName[i];
                person.LastName = LastName[i];
                personsStack.Add(person);
            }

            string perPopedLast = PersonStack.PopedLast(personsStack);

            Console.WriteLine(perPopedLast);

            ///Queue

            Console.WriteLine();
            Console.WriteLine("Queue");
            List<PersonQueue> personsQ = new List<PersonQueue>();

            for (int i = 0; i < FirstName.Count; i++)
            {
                PersonQueue person = new PersonQueue();
                person.FirstName = FirstName[i];
                person.LastName = LastName[i];
                personsQ.Add(person);
            }

            List<PersonQueue> perQ = new List<PersonQueue>();
            perQ = PersonQueue.PopFirst(personsQ);

            foreach (PersonQueue p in perQ)
            {
                Console.WriteLine(p.FullName);
            }


            /// Dequeue
            Console.WriteLine();
            Console.WriteLine("DeQueue First Object");
            List<PersonQueue> personsDeq = new List<PersonQueue>();

            for (int i = 0; i < FirstName.Count; i++)
            {
                PersonQueue person = new PersonQueue();
                person.FirstName = FirstName[i];
                person.LastName = LastName[i];
                personsQ.Add(person);
            }

            string perDeq =  PersonQueue.Dequeue(personsQ);

           Console.WriteLine(perDeq);

         
            

            Console.ReadLine();

        }
    }
}
