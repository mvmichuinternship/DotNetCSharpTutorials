using EmployeeRequestTrackerBLLibrary;
using RequestTrackerAppModelLibrary;
using RequestTrackerDALLibrary;
using System.Reflection;
using System.Xml.Linq;

namespace EmployeeRequestTracker
{
    internal class Program
    {

        IRepository<int, Employee> repo = new EmployeeRepository();
        IEmployee empService;
        void AddEmp()
        {
            
            empService = new EmployeeBL(repo);

            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter mobile");
            string mobile = Console.ReadLine();
            Console.WriteLine("Enter salary");
            int salary = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee() { Id=id, Mobile=mobile, Name=name, Role="User", Salary=salary };

            var result = empService.Register(employee);
            Console.WriteLine(employee);
            Console.WriteLine(result.Id);
            Console.WriteLine(result.Name);
            Console.WriteLine(result.Mobile);
            Console.WriteLine(result.Salary);
            Console.WriteLine(result.Role);
        }
        void DelEmp()
        {
            var result= repo.Delete(1);
            
            Console.WriteLine(result.Id);
            Console.WriteLine(result.Name);
            Console.WriteLine(result.Mobile);
            Console.WriteLine(result.Salary);
            Console.WriteLine(result.Role);
        }
        void updEmp()
        {
            Employee employee = new Employee() { Id = 1, Mobile = "mobile", Name = "name", Role = "User", Salary = 1000 };
            var result = repo.Update(employee);


        }

        void GetEmpById()
        {
            empService = new EmployeeBL(repo);
            var result = empService.Login(1,"mv");
            Console.WriteLine(result.Id);
            Console.WriteLine(result.Name);
            Console.WriteLine(result.Mobile);
            Console.WriteLine(result.Salary);
            Console.WriteLine(result.Role);
        }

        void GetAllEmp()
        {
            var res= repo.GetAll();
            foreach(Employee emp in res)
            {
                Console.WriteLine(emp.Id);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Role);
                Console.WriteLine(emp.Salary);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.AddEmp();
            //program.AddEmp();
            //program.updEmp();
            program.GetEmpById();
            //program.GetAllEmp();
            //program.DelEmp();

        }
    }
}
