using System;
using System.Runtime.CompilerServices;

public class Directeur
{
    private static GestionEmployes gestionEmployes;
    private Directeur() { }
    public static bool setGestionEmployes(int action)
    {
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
        return true;

    }


    public static Directeur getInstance()
    {
        if (gestionEmployes == null)
        {
            gestionEmployes = new GestionEmployes();
            return new Directeur();
        }
        return new Directeur();
    }

    public static Directeur getInstance(GestionEmployes gestionEmploye)
    {
        if (gestionEmployes == null)
        {
            gestionEmployes = gestionEmploye;
            return new Directeur();
        }
        return new Directeur();
    }
}