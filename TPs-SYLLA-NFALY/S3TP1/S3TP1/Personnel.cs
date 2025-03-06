public abstract class Personnel : Personne, IRessourcesHumaines
{
    private String code;

    private String nom;

    private String prenom;
    private double salaireMensuel;

	private double prime;

	private String bureau;

	public abstract double calculer_salaire();


	/// <see>IRessourcesHumaines#afficher_enseignant()</see>
	public void afficher_enseignant()
	{

	}


	/// <see>IRessourcesHumaines#rechercher_ens(String)</see>
	public int rechercher_ens(String code)
	{
		return 0;
	}

}

