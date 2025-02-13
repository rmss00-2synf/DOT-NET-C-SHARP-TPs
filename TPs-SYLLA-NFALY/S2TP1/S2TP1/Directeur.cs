using System;
using System.Runtime.CompilerServices;

public class Directeur
{
    private static GestionEmployes gestionEmployes;
    //private Directeur(GestionEmployes gestionEmployes)
    //{
    //    this.gestionEmployes = gestionEmployes;
    //}
    public static bool setGestionEmployes(GestionEmployes gestionEmployess)
    {
        gestionEmployes = new GestionEmployes();
        gestionEmployes = gestionEmployess;
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
            switch (action)
            {
                case 0:
                    Console.WriteLine("Enter Employee Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Employee Position:");
                    string position = Console.ReadLine();
                    Console.WriteLine("Enter Employee Salary:");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    gestionEmployes.AddEmployee(new Employee(name, position, salary));
                    break;
                case 1:
                    Console.WriteLine("Total Salary:");
                    Console.WriteLine(gestionEmployes.GetTotalSalary());
                    break;
                case 2:
                    Console.WriteLine("Average Salary:");
                    Console.WriteLine(gestionEmployes.GetAverageSalary());
                    break;
                case 3:
                    gestionEmployes.DisplayEmployees();
                    break;
                case 4:
                    Console.WriteLine("Enter Employee Name:");
                    String nom = Console.ReadLine();
                    gestionEmployes.RemoveEmployee(nom);
                    break;
                case -1:
                    Console.WriteLine("Thank u :)");
                    return true;
                default:
                    Console.WriteLine("Invalid Action");
                    return false;
            }

        }
    }
}