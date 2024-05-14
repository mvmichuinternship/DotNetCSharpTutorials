using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1Consoleapp
{
    public class Mv
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Experience { get; set; } 
        public int Salary {  get; set; }

        public Mv() { }

        public Mv(int id, string name, int exp, int sal)
        {
            Id = id;
            Name = name;
            Experience = exp;
            Salary = sal;
        }

    }
}
