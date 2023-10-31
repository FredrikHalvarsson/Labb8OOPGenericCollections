namespace Labb8OOPGenericCollections
{
    internal class Program
    {
        static void Main()
        {
            Employee e1 = new Employee(100, "Fredrik", "Male", 14000);
            Employee e2 = new Employee(101, "Therese", "Female", 35000);
            Employee e3 = new Employee(102, "Kalle","Male",45000);
            Employee e4 = new Employee(103, "Erik", "Male", 14000);
            Employee e5 = new Employee(104, "Carina", "Female", 40000);

            Stack<Employee> empStack = new Stack<Employee>();
            empStack.Push(e1);
            empStack.Push(e2);
            empStack.Push(e3);
            empStack.Push(e4);
            empStack.Push(e5);

            Console.WriteLine("***********************************************************");
            foreach (var item in empStack)
            {
                item.Display();
                Console.WriteLine(empStack.Count() + " Items left in stack");
            }
            Console.WriteLine("*************************** Pop ***************************");

            do
            {
                var poppedEmp = empStack.Pop();
                poppedEmp.Display();
                Console.WriteLine(empStack.Count() + " Items left in stack");
            } while (empStack.Count() > 0);
            empStack.Push(e1);
            empStack.Push(e2);
            empStack.Push(e3);
            empStack.Push(e4);
            empStack.Push(e5);

            Console.WriteLine("*************************** Peek **************************");
            var peekEmp = empStack.Peek();
            peekEmp.Display();
            Console.WriteLine(empStack.Count() + " Items left in stack");
            peekEmp = empStack.Peek();
            peekEmp.Display();
            Console.WriteLine(empStack.Count() + " Items left in stack");

            Console.WriteLine("************************* contains ************************");
            if (empStack.Contains(e3))
            {
                Console.WriteLine("Employee 3 is in stack");
            }
            else
            {
                Console.WriteLine("Employee 3 is not in stack");
            }

            Console.WriteLine("************************** Part 2 *************************");
            Console.WriteLine("*************************** List **************************");
            List<Employee> empList = new List<Employee>() { e1,e2,e3,e4,e5};
            if (empList.Contains(e3))
            {
                Console.WriteLine("Employee 3 object exists in list");
            }
            else
            {
                Console.WriteLine("Employee 3 object does not exists in list");
            }

            Console.WriteLine("*************************** Find **************************");
            var firstMaleEmp = empList.Find(e => e.Gender == "Male");
            firstMaleEmp.Display();

            Console.WriteLine("************************* Find All ************************");
            List<Employee> maleEmpList = empList.FindAll(e => e.Gender == "Male");
            foreach(var item in maleEmpList)
            {
                item.Display();
            }
        }
    }
}