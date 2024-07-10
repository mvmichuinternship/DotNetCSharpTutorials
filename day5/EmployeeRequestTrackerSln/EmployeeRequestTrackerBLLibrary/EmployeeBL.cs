using RequestTrackerAppModelLibrary;
using RequestTrackerDALLibrary;

namespace EmployeeRequestTrackerBLLibrary
{
    public class EmployeeBL : IEmployee
    {
        private readonly IRepository<int, Employee> _employeeService;
        private readonly EmployeeRepository _employeeDirectService;
        public EmployeeBL(IRepository<int,Employee> employeeService) 
        {
            //_employeeService = new EmployeeRepository();
            _employeeService = employeeService;
            _employeeDirectService = new EmployeeRepository();
        }


        public Employee Login(int id, string name)
        {
            var emp=_employeeService.Get(id);
            if(emp.Name== name)
            {
                Console.WriteLine("Login Success!");
                return emp;
            }
            throw new Exception("Login Failed");
        }

        public Employee Register(Employee employee)
        {
            var emp = _employeeService.Add(employee);
            if(emp!= null)
            {
                Console.WriteLine("Registered Successfully");
                return emp;
            }
            throw new Exception("Cannot register at the moment");
        }
    }
}
