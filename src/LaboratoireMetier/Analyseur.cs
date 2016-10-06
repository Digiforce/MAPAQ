using LaboratoireData.Models;
using System;

namespace LaboratoireMetier
{
    public class Analyseur : IAnalyseur
    {
        private ISpectrometre _spectrometre;

        public Analyseur(ISpectrometre spectrometre)
        {
            if (spectrometre == null)
                throw new ArgumentNullException("spectrometre");

            _spectrometre = spectrometre;
        }

        public IAnalyse Demarrer(IEchantillon  echantillon)
        {
            TypeCristal   resultat;

            // TODO : Idéalement, il faudrait remplacer l'appel au constructeur par un patron de Factory.
            IAnalyse analyse = new Analyse();

            resultat = _spectrometre.Analyser(echantillon);

            analyse.Resultat = resultat;
            analyse.DateAnalyse = DateTime.Now;
            analyse.Echantillon = echantillon;

            return analyse;
        }
    }
}
