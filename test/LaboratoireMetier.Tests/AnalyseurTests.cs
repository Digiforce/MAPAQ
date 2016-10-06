using LaboratoireData.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace LaboratoireMetier.Tests
{
    public class AnalyseurTests
    {


        [Fact]
        public void Si_Echantillon_Est_Analysé_Alors_Analyse_Est_Pas_Vide()
        {
            // Prepare
            Mock<IEchantillon> echantillonMock = new Mock<IEchantillon>();
            Mock<ISpectrometre> spectrometreMock = new Mock<ISpectrometre>();
            IAnalyse resultat;
            spectrometreMock.Setup(x => x.Analyser(It.IsAny<IEchantillon>())).Returns(TypeCristal.Rubis);

            IAnalyseur analyseur = new Analyseur(spectrometreMock.Object);

            // Execute
            resultat = analyseur.Demarrer(echantillonMock.Object);

            // Valide
            Assert.NotNull(resultat);
        }

        [Fact]
        public void Si_Echantillon_Est_Analysé_Alors_Echantillon_Est_Pas_Vide()
        {
            // Prepare
            Mock<IEchantillon> echantillonMock = new Mock<IEchantillon>();
            Mock<ISpectrometre> spectrometreMock = new Mock<ISpectrometre>();
            IAnalyse resultat;
            spectrometreMock.Setup(x => x.Analyser(It.IsAny<IEchantillon>())).Returns(TypeCristal.Rubis);

            IAnalyseur analyseur = new Analyseur(spectrometreMock.Object);

            // Execute
            resultat = analyseur.Demarrer(echantillonMock.Object);

            // Valide
            Assert.NotNull(resultat.Echantillon);
        }

        [Fact]
        public void Si_Echantillon_Est_Analysé_Alors_DateEchantillon_Est_Now()
        {
            // Prepare
            Mock<IEchantillon> echantillonMock = new Mock<IEchantillon>();
            Mock<ISpectrometre> spectrometreMock = new Mock<ISpectrometre>();
            IAnalyse resultat;
            spectrometreMock.Setup(x => x.Analyser(It.IsAny<IEchantillon>())).Returns(TypeCristal.Rubis );
            IAnalyse attendu = new Analyse();
            attendu.DateAnalyse = DateTime.Now;

            IAnalyseur analyseur = new Analyseur(spectrometreMock.Object);

            // Execute
            resultat = analyseur.Demarrer(echantillonMock.Object);

            // Valide
            Assert.Equal(attendu.DateAnalyse , resultat.DateAnalyse);

        }
    }
}
