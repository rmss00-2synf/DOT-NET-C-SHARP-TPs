using System;
public class Admin : Personne
{
    private double salaireMensuel;
    private double prime;
    private string bureau;


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

    // Méthode pour calculer le salaire
    public double CalculerSalaire()
    {
        // Le salaire est calculé comme la somme du salaire mensuel et de la prime
        return salaireMensuel + prime;
    }

}

