using System.Collections.Generic;


public class Enseignant : Personne
{
    // Attributs priv�s
    private double salaireMensuel;
    private double prime;
    private string bureau;
    private double heureSup;
    private grade grade;
    private int volumeHoraire;
    private Dictionary<string, List<Etudiant>> groupes;

    // Getters et Setters pour chaque attribut

    public double SalaireMensuel
    {
        get { return salaireMensuel; }
        set { salaireMensuel = value; }
    }

    public double Prime
    {
        get { return prime; }
        set { prime = value; }
    }

    public string Bureau
    {
        get { return bureau; }
        set { bureau = value; }
    }

    public double HeureSup
    {
        get { return heureSup; }
        set { heureSup = value; }
    }

    public grade Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    public int VolumeHoraire
    {
        get { return volumeHoraire; }
        set { volumeHoraire = value; }
    }

    public Dictionary<string, List<Etudiant>> Groupes
    {
        get { return groupes; }
        set { groupes = value; }
    }


    public void Afficher_ens()
    {
        Console.WriteLine($"Code : {Code}");
        Console.WriteLine($"Nom : {Nom}");
        Console.WriteLine($"Pr�nom : {Prenom}");
        Console.WriteLine($"Grade : {Grade}");
        Console.WriteLine($"Salaire Mensuel : {SalaireMensuel} MAD");
        Console.WriteLine($"Prime : {Prime} MAD");
        Console.WriteLine($"Heures Suppl�mentaires : {HeureSup}");
        Console.WriteLine($"Bureau : {Bureau}");
        Console.WriteLine($"Volume Horaire : {VolumeHoraire} heures");
        Console.WriteLine("Groupes d'�tudiants :");

        foreach (var groupe in groupes)
        {
            Console.WriteLine($" - Groupe {groupe.Key} : {groupe.Value.Count} �tudiants");
            foreach (var etudiant in groupe.Value)
            {
                Console.WriteLine("Les etudiants:");
                etudiant.afficher_etd();
            }
        }
    }


    public double CalculerSalaire()
    {
        if (grade == grade.PH)
        {
            
        }
        return salaireMensuel + prime + heureSup;
    }
}

public enum grade
{
    PA,
    PH,
    PES
}
