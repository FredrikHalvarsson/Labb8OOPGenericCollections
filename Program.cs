namespace Labb8OOPGenericCollections
{
    internal class Program
    {
        static void Main()
        {
            //Skapar 5 objekt av klassen Employee
            Employee e1 = new Employee(100, "Fredrik", "Male", 14000);
            Employee e2 = new Employee(101, "Therese", "Female", 35000);
            Employee e3 = new Employee(102, "Kalle","Male",45000);
            Employee e4 = new Employee(103, "Erik", "Male", 14000);
            Employee e5 = new Employee(104, "Carina", "Female", 40000);

            //Skapar en stack för att lagra datatypen Employee
            // och lägger till objekten med Push
            Stack<Employee> empStack = new Stack<Employee>();
            empStack.Push(e1);
            empStack.Push(e2);
            empStack.Push(e3);
            empStack.Push(e4);
            empStack.Push(e5);

            //foreachloop som skriver ut alla objekt i stacken, eftersom det är en stack så skrivs dem ut i LIFO ordning (sista objektet först)
            Console.WriteLine("***********************************************************");
            foreach (var item in empStack)
            {
                item.Display();
                Console.WriteLine(empStack.Count() + " Items left in stack");
            }
            Console.WriteLine("*************************** Pop ***************************");

            //Plockar objekt från stacken med Pop
            do
            {
                var poppedEmp = empStack.Pop();
                poppedEmp.Display();
                Console.WriteLine(empStack.Count() + " Items left in stack");
            } while (empStack.Count() > 0);

            //nu är då stacken tom så vi fyller den igen för att fortsätta testa.
            empStack.Push(e1);
            empStack.Push(e2);
            empStack.Push(e3);
            empStack.Push(e4);
            empStack.Push(e5);

            Console.WriteLine("*************************** Peek **************************");
            //här använder vi Peek för att kolla på nästa objekt i stacken, detta tar inte bort objektet som Pop gör
            var peekEmp = empStack.Peek();
            peekEmp.Display();
            //kollar hur många objekt vi har kvar i stacken för att visa att Peek endast tittade på objektet.
            Console.WriteLine(empStack.Count() + " Items left in stack");
            peekEmp = empStack.Peek();
            peekEmp.Display();
            Console.WriteLine(empStack.Count() + " Items left in stack");

            Console.WriteLine("************************* contains ************************");
            //Contains kollar om ett specifikt objekt finns i stacken
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
            //Skapar en Lista med datatypen Employee och lägger till våra objekt i den. (att använda Push lika som i stacken hade även funkat här)
            List<Employee> empList = new List<Employee>() { e1,e2,e3,e4,e5};
            //contains går även att använda i en lista
            if (empList.Contains(e3))
            {
                Console.WriteLine("Employee 3 object exists in list");
            }
            else
            {
                Console.WriteLine("Employee 3 object does not exists in list");
            }

            Console.WriteLine("*************************** Find **************************");
            //Find hittar det första objektet med de värden som vi matar in i .Find, här letar vi efter det första objektet med egenskapen Gender satt som "Male"
            var firstMaleEmp = empList.Find(e => e.Gender == "Male");
            firstMaleEmp.Display();

            Console.WriteLine("************************* Find All ************************");
            //FindAll gör samma sak men hittar alla objekt som fyller kraven, Här lägger jag till alla objekt som metoden hittar i en ny lista eftersom jag inte kan lagra flera objekt i en enkel variabel.
            List<Employee> maleEmpList = empList.FindAll(e => e.Gender == "Male");
            foreach(var item in maleEmpList)
            {
                item.Display();
            }
        }
    }
}