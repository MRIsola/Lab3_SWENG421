using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class Tasks
    {
        private string ID;
        private string dueDate;
        private string description;

        public Tasks()
        {
            ID = "0000";
            dueDate = "0/0/0000";
            description= "Description"; 
        }

        public Tasks(string iD, string dueDate, string description)
        {
            ID = iD;
            this.dueDate = dueDate;
            this.description = description;
        }

        public string getID()
        {
            return ID;
        }


    }
}
