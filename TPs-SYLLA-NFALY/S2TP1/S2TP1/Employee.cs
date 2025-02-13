using System;
public class Employee
{
    public string Nom { get; set; }
    public string Post { get; set; }
    public double Salaire { get; set; }

    public DateTime DateEmbauche { get; set; }
    public Employee(string name, string position, double salary)
    {
        Nom = name;
        Post = position;
        Salaire = salary;
        DateEmbauche = DateTime.Now;
    }
    public override string ToString()
    {
        return "Nom: " + Nom + " Poste: " + Post + " Salaire: " + Salaire + " Date d'embauche: " + DateEmbauche;
    }
}


