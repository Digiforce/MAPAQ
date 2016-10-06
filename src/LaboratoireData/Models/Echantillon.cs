using System;

namespace LaboratoireData.Models
{
    //La classe doit être public afin d'être visible au projet de tests.
    public class Echantillon : IEchantillon
    {
        public int Id { get; set; }
        public string Couleur { get; set; }
        public DateTime  DatePrelevement { get; set; }

        public Echantillon ()
        {

        }

    }
}
