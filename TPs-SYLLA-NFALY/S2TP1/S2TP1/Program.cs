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
        Directeur.setGestionEmployes(gestionEmployes);



    }
}