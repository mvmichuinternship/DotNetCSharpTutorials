namespace day1Consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Display();
                choice = GetInput();
                if (choice != 0)
                {
                int a = GetInput();
                int b = GetInput();
                int c;

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    case 1:
                        c = Add(a, b);
                        Console.WriteLine(c);
                        break;
                    case 2:
                        c = Sub(a, b);
                        Console.WriteLine(c);
                        break;
                    case 3:
                        c = Mul(a, b);
                        Console.WriteLine(c);
                        break;
                    case 4:
                        c = Div(a, b);
                        Console.WriteLine(c);
                        break;
                    case 5:
                        c = Modulo(a, b);
                        Console.WriteLine(c);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                }
            } while (choice!=0);


            string str = "Mridula";
            foreach (var id in str)
            {
                Console.WriteLine(id);
            }

            //Mv var1 = new Mv();
            //var1.Id = 1;
            //Mv var2 = new Mv(101, "mv", 2, 1000);
            //Mv var3 = new Mv() { Id = 3, Experience=2, Name ="vk", Salary=1500 };
        }

        static int Add(int a, int b) {  return a + b; }
        static int Sub(int a, int b) { return a - b;}
        static int Mul(int a, int b) { return a * b;}
        static int Div(int a, int b) { return a / b;}
        static int Modulo(int a, int b) { return a % b;}
        static int GetInput()
        {
            Console.WriteLine("Enter Input");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }

        static void Display()
        {
            Console.WriteLine("Choose");
            Console.WriteLine("1. Add \n 2. Sub \n 3. Mul \n 4. Div \n 5. Mod \n 0. Exit");
        }
        
    }
}
