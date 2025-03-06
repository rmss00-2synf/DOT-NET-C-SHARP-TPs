using System.Diagnostics;

public class Etudiant : Personne
{
    private string code;
    private string nom;
    private string prenom;
    private string niveau;
	private double moyenne_annuelle;
	private string groupe;

    public string Code
    {
        get { return code; }
        set { code = value; }
    }

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public string Prenom
    {
        get { return prenom; }
        set { prenom = value; }
    }

    public string Niveau
    {
        get { return niveau; }
        set { niveau = value; }
    }

    public string Groupe
    {
        get { return groupe; }
        set { groupe = value; }
    }
    public void afficher_etd()
	{
        Console.WriteLine($"Code : {Code}");
        Console.WriteLine($"Nom : {Nom}");
        Console.WriteLine($"Prénom : {Prenom}");
        Console.WriteLine($"Niveau : {Niveau}");
        Console.WriteLine($"Moyenne annuelle : {moyenne_annuelle}");
        Console.WriteLine($"Groupe : {Groupe}");
        
    }

	public void ajouter_etudiant(String intitulerGrp)
	{

	}

}

