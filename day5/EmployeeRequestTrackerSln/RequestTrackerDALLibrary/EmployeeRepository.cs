using System.Collections.Generic;
using RequestTrackerAppModelLibrary;

namespace RequestTrackerDALLibrary
{
    public class EmployeeRepository : IRepository<int, Employee>
    {
        private readonly Dictionary<int, Employee> _employee;
        public EmployeeRepository() 
        { 
            _employee = new Dictionary<int, Employee>();
        }
        public Employee Add(Employee item)
        {
            if (_employee.ContainsValue(item))
            {
                return null;
            }
            _employee.Add(item.Id, item);
            return item;
        }

        public Employee Delete(int key)
        {
            if(_employee.ContainsKey(key)) {
                var a= _employee[key];
                _employee.Remove(key);
                return a;
            }
            return null;
            //throw new Exception("invalid key");
        }

        public Employee Get(int key)
        {
            if (_employee.ContainsKey(key))
            {
                return _employee[key];
            }
            throw new Exception("Invalid key");
        }

        public IList<Employee> GetAll()
        {
            IList<Employee> list = new List<Employee>();
            if (_employee.Count == 0)
            {
                throw new Exception("Empty List");
            }
            foreach (var item in _employee)
            {
                list.Add(item.Value);
            }
            return list;
        }

        public Employee Update(Employee employee)
        {
            if( !_employee.ContainsKey(employee.Id)) {
                return null;
            }
            var result = _employee[employee.Id] = employee;
            return result;

        }

        public Employee GetByEmployee(Employee name)
        {
            if (_employee.ContainsValue(name))
            {
                return name;
            }
            throw new Exception("Invalid key");
        }

    }
}
