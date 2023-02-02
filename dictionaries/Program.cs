namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {



            Employee[] employees ={
            new Employee("ceo","sumon",33,25),
            new Employee("cfo","jonny",33,25),
            new Employee("intern","mikka",33,25),
            new Employee("cto","mary",33,25) };



            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();




            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            //update 
            string keyUpdate = "cto";
            if (employeesDirectory.ContainsKey(keyUpdate))
            {
                employeesDirectory[keyUpdate] = new Employee("cto", "nika", 40, 32);
            }
            else
            {
                Console.WriteLine("key does not exist");
            }



            //remove
            string keyRemove = "intern";
            if (employeesDirectory.Remove(keyRemove))
            {
                Console.WriteLine($"employee has been deleted");
            }
            else
            {
                Console.WriteLine("key does not exist");
            }

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                Console.WriteLine("key is {0}", keyValuePair.Key);
                Employee employeeValue = keyValuePair.Value;
                Console.WriteLine("Employe Name: {0}, Role: {1}, Salary: {2}\n", employeeValue.Name, employeeValue.Role, employeeValue.Salary);


            }




            string key = "cfo";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];
                Console.WriteLine("Employe Name: {0}, Role: {1}, Salary: {2}\n", empl.Name, empl.Role, empl.Salary);

            }
            else
            {
                Console.WriteLine("No emploees found with this key{0}", key);


            }

            //another way
            Employee result = null;
            if (employeesDirectory.TryGetValue("ceo", out result))
            {
                Console.WriteLine("Employe Name: {0}, Role: {1}, Salary: {2}\n", result.Name, result.Role, result.Salary);

            }
            else
            {
                Console.WriteLine("key does not exist.");
            }

            //Employee empl = employeesDirectory["ceo"];



            Dictionary<int, string> myDictionary = new Dictionary<int, string>();



        }
    }
}