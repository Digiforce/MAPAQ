using System;

namespace LaboratoireData.Models
{
    public class Analyse : IAnalyse
    {
        public int Id { get; set; }
        public DateTime DateAnalyse { get; set; }
        public IEchantillon  Echantillon { get; set; }
        public TypeCristal  Resultat { get; set; }
    }
}
