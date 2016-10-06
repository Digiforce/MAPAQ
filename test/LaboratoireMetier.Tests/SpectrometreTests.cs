using LaboratoireData.Models;
using System;
using Xunit;


namespace LaboratoireMetier.Tests
{
    public class SpectrometreTests
    {
        [Fact]
        public void Si_Echantillon_Est_Rouge_Alors_Resultat_Est_Rubis()
        {
            // Prepare
            Echantillon echantillon = new Echantillon ();
            ISpectrometre spectrometre = new Spectrometre();
            TypeCristal resultat;
            TypeCristal  attendu = TypeCristal.Rubis ;

            echantillon.Couleur = "Rouge";

            // Execute
            resultat = spectrometre.Analyser(echantillon);

            // Valide
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void Si_Echantillon_Est_Vert_Alors_Resultat_Est_Emeraude()
        {
            // Prepare
            Echantillon echantillon = new Echantillon();
            ISpectrometre spectrometre = new Spectrometre();
            TypeCristal resultat;
            TypeCristal attendu = TypeCristal.Emeraude ;

            echantillon.Couleur = "Vert";

            // Execute
            resultat = spectrometre.Analyser(echantillon);

            // Valide
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void Inconnu()
        {
            // Prepare
            Echantillon echantillon = new Echantillon();
            ISpectrometre spectrometre = new Spectrometre();
            TypeCristal resultat;
            TypeCristal attendu = TypeCristal.Inconnu;

            echantillon.Couleur = "Brun";

            // Execute
            resultat = spectrometre.Analyser(echantillon);

            // Valide
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void Si_Echantillon_Est_Null_Alors_Exception_Attendue()
        {
            // Prepare
            Echantillon echantillon = null;
            ISpectrometre spectrometre = new Spectrometre();

            // Execute
            // Ne pas exécuter le code métier ici. 
            // Pour tester les exceptions, le code métier doit être exécuté dans l'instruction Assert.

            // Valide
            Assert.Throws<ArgumentNullException>(() => spectrometre.Analyser (echantillon));
        }

        [Fact]
        public void Si_Echantillon_Est_VERT_Alors_Resultat_Est_Emeraude()
        {
            // Prepare
            Echantillon echantillon = new Echantillon();
            ISpectrometre spectrometre = new Spectrometre();
            TypeCristal resultat;
            TypeCristal attendu = TypeCristal.Emeraude;

            echantillon.Couleur = "VERT";

            // Execute
            resultat = spectrometre.Analyser(echantillon);

            // Valide
            Assert.Equal(attendu, resultat);
        }


    }
}
