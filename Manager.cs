using AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class Manager : Person
    {
        public Manager()
        {
        }

        public Manager(string name, int age, string title) : base(name, age, title)
        {
        }

        public void evaluate(Person p, int score)
        {
            p.setEval(score);
        }
    }
}
