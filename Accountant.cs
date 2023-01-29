using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class Accountant: Person
    {
        public Accountant()
        {
        }

        public Accountant(string name, int age, string title) : base(name, age, title)
        {
        }

        public void Update(Person p, int amt)
        {
            p.setSalary(amt);
        }

    }
}
