
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
            throw new NotImplementedException();
        }

        public Employee Get(int key)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee Update(int key)
        {
            throw new NotImplementedException();
        }
    }
}
