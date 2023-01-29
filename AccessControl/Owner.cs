using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class Owner : Person
    {
        public Owner()
        {
        }

        public Owner(string name, int age, string title) : base(name, age, title)
        {
        }

        public void Message(string message, Person p)
        {

            Console.WriteLine("Dear " + p.getName() + ",");
            Console.WriteLine(message);
        }
             
    }
}
