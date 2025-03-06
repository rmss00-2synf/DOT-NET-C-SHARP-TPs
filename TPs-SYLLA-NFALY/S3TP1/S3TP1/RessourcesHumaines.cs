using System.Net;

public class RessourcesHumaines : IRessourcesHumaines
{
	private static List<Personne> GRH;
    private static List<Groupe> GRP;

    public List<Personne> GRHs
    {
        get { return GRH; }
        set { GRH = value; }
    }

    public List<Groupe> GRPs
    {
        get { return GRP; }
        set { GRP = value; }
    }


    public int rechercher_ens(string code)
    {
        return 0;
    }

    public bool Ajouter_etudiant(string nomGroupe, Etudiant etd) {
        
        foreach (Groupe item in GRP)
        {
            if (item.Nom == nomGroupe)
            {
                etd.Groupe = nomGroupe;
                GRH.Add(etd);
                List<Etudiant> etudiants = item.Etudiants;
                etudiants.Add(etd);
                item.Etudiants= etudiants;
            }

            return true;

        }

        return false;
    }


    public void Ajouter_groupe(string nomGroupe, Enseignant ens) {
        
    }
    public void Afficher_grp(string nomGroupe) { }
    public void Afficher_etd(int code) { }
    public void Afficher_ens(int code) { }

}

