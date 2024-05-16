using RequestTrackerAppModelLibrary;
using RequestTrackerDALLibrary;

namespace EmployeeRequestTracker
{
    internal class Program
    {

        void AddEmp()
        {
            EmployeeRepository repo = new EmployeeRepository();

            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter mobile");
            string mobile = Console.ReadLine();
            Console.WriteLine("Enter salary");
            int salary = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee() { Id=id, Mobile=mobile, Name=name, Role="User", Salary=salary };

            var result = repo.Add(employee);
            Console.WriteLine(employee);
            Console.WriteLine(result.Id);
            Console.WriteLine(result.Name);
            Console.WriteLine(result.Mobile);
            Console.WriteLine(result.Salary);
            Console.WriteLine(result.Role);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.AddEmp();

            
        }
    }
}
