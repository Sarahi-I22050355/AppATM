using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppATM.Classes
{
    internal abstract class Person
    {
        protected int id;
        protected string name;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person()
        {
            name= string.Empty;
            id = 0;
        }
        public Person(string name, int id) 
        { 
            this.id = id;
            this.name = name;
        }

    }
}
