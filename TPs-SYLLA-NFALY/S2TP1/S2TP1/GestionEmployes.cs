using System;

public class GestionEmployes
{
    private List<Employee> employees;
    public GestionEmployes()
    {
        employees = new List<Employee>();
    }
    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }
    public void DisplayEmployees()
    {
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
    public bool RemoveEmployee(string name)
    {
        foreach (Employee employee in employees)
        {
            if (employee.Nom.ToLower() == name.ToLower())
            {
                employees.Remove(employee);
                return true;
            }
        }
        return false;
    }

    public double GetTotalSalary()
    {
        double total = 0;
        foreach (Employee employee in employees)
        {
            total += employee.Salaire;
        }
        return total;
    }

    public double GetAverageSalary()
    {
        return GetTotalSalary() / employees.Count;
    }



}
