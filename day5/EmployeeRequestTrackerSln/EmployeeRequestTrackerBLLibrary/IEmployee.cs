using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestTrackerAppModelLibrary;

namespace EmployeeRequestTrackerBLLibrary
{
    public interface IEmployee
    {
        public Employee Register(Employee employee);
        public Employee Login(int id, string name);
    }
}
