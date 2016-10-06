using LaboratoireData.Models;
using System;

namespace LaboratoireMetier
{
    public class Spectrometre : ISpectrometre 
    {
        public Spectrometre()
        {

        }

        public TypeCristal   Analyser (IEchantillon echantillon)
        {

            TypeCristal resultat = TypeCristal.Inconnu;

            if (echantillon == null)
                throw new ArgumentNullException("echantillon");

            if (echantillon.Couleur == "Rouge")
                resultat = TypeCristal.Rubis ;
            else if (echantillon.Couleur == "Vert")
                resultat = TypeCristal.Emeraude ;
            else if (echantillon.Couleur == "Bleu")
                resultat = TypeCristal.Saphir ;

            return resultat;
        }
    }
}