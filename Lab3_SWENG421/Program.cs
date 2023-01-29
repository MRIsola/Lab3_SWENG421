using AccessControl;
using System;

namespace PacakgeVisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner("Craig", 30, "owner");
            Manager man1 = new Manager("John", 25, "manager");
            Manager man2 = new Manager("Mary", 35, "manager");
            Accountant acc1 = new Accountant("Jane", 40, "accountant");
            Accountant acc2 = new Accountant("Joe", 45, "accountant");
            Blacksmith bs1 = new Blacksmith("Jack", 27, "blacksmith");
            Blacksmith bs2 = new Blacksmith("Katie", 37, "blacksmith");
            Blacksmith bs3 = new Blacksmith("Amy", 21, "blacksmith");
            Blacksmith bs4 = new Blacksmith("Lin", 42, "blacksmith");
            Blacksmith bs5 = new Blacksmith("Greg", 33, "blacksmith");
            Tasks t1 = new Tasks("T1", "2/20/2023", "The first task");
            Tasks t2 = new Tasks("T2", "2/21/2023", "The second task");
            Tasks t3 = new Tasks("T3", "2/22/2023", "This is supposed to be Lin's task");


            owner.Message("Good Job", man1);
            owner.Message("Good Job", acc1);
            owner.Message("Good Job", bs1);

            bs1.Perform(t1);
            bs1.Perform(t2);

            Console.WriteLine(bs5.getSalary());
            acc1.Update(bs5, 36000);
            Console.WriteLine(bs5.getSalary());

            acc1.Perform(t3);

            man2.evaluate(bs1, 4);
            Console.WriteLine(bs1.getEval());
            man2.evaluate(bs2, 5);
            Console.WriteLine(bs2.getEval());

        }
    }
}