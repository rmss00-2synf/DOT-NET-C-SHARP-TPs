using System;

class Program
{
    static void Main(string[] args)
    {
        GestionEmployes gestionEmployes = new GestionEmployes();
        gestionEmployes.AddEmployee(new Employee("Ahmed", "PDG", 10000));
        gestionEmployes.AddEmployee(new Employee("Ali", "PDG", 20000));
        gestionEmployes.AddEmployee(new Employee("Mohamed", "PDG", 30000));
        gestionEmployes.AddEmployee(new Employee("Hassan", "PDG", 40000));

        Directeur.getInstance(gestionEmployes);   
        

        while (true)
        {
            Console.WriteLine("0: Add Employee");
            Console.WriteLine("1: Get Total Salary");
            Console.WriteLine("2: Get Average Salary");
            Console.WriteLine("3: Display Employees");
            Console.WriteLine("4: Remove Employee");
            Console.WriteLine("-1: Exit");
            Console.WriteLine("Choose an action:...");
            int action = Convert.ToInt32(Console.ReadLine());
            
            Directeur.setGestionEmployes(action);
            if (action == -1)
                break;
        }

    }
}