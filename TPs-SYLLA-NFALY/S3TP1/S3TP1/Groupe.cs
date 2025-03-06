using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;


public class Groupe
{
	private string nom;

	private List<Etudiant> etudiants;

	public string Nom
	{
		get { return nom; }
		set { nom = value; }
	}

	public List<Etudiant> Etudiants
	{
        get { return etudiants; }
        set { etudiants=value; }
	}


    public void afficher_grp()
	{
        Console.WriteLine($"Nom : {Nom}");
        Console.WriteLine("Les étudiants du groupes :");

        foreach (var etudiant in etudiants)
        {
			etudiant.afficher_etd();
        }

}

	public void ajouter_groupe(String intitulerGrp, Enseignant code)
	{

	}

}

