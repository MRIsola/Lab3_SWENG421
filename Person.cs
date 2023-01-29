using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class Person
    {
        private string name;
        private int age;
        private string title;
        private int salary;
        private int evaluation = 0;

        public Person()
        {
            this.name = "default";
            this.age = 0;
            this.title = "default";
            this.salary = 0; 
        }

        public Person(string name, int age, string title)
        {
            this.name = name;
            this.age = age;
            this.title = title;
            if ( title == "manager" )
            { 
                this.salary = 50000; 
            }
            else if ( title == "accountant" )
            { 
                this.salary = 45000;
            }
            else if ( title == "blacksmith" )
            { 
                this.salary = 35000; 
            }
            else
            {
                this.salary = 0;
            }
        }

        internal void setSalary(int amt)
        {
            this.salary = amt;
        }

        public int getSalary()
        {
            return salary;
        }

        internal void setEval(int rating)
        {
            this.evaluation = rating;
        }

        public int getEval()
        {
            return evaluation;
        }

        public string getName()
        {
            return name;
        }

        public void Perform(Tasks t)
        {
            Console.WriteLine("Task " + t.getID() + " completed by " + this.getName());
        }
    }
}
