using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoireData.Models;

namespace LaboratoireData
{
    public class LaboratoireRepositoryMemoire : ILaboratoireRepository
    {
        private Dictionary<int, IAnalyse> _analyses;

        public LaboratoireRepositoryMemoire()
        {
            _analyses = new Dictionary<int, IAnalyse>();
        }

        public void DeleteAnalyse(int analyseID)
        {
            if (_analyses.ContainsKey(analyseID))
                _analyses.Remove(analyseID);
        }

        public IAnalyse GetAnalyseByID(int analyseId)
        {
            IAnalyse element = null;
            if (_analyses.ContainsKey(analyseId))
                element = _analyses[analyseId];

            return element;
        }

        public IEnumerable<IAnalyse> GetAnalyses()
        {
            return _analyses.Values.AsEnumerable<IAnalyse>();
        }

        public void InsertAnalyse(IAnalyse analyse)
        {

            // Assigne un Id au nouvel élément
            if (analyse.Id  == 0)
            {
                int maxId = 0;

                if (_analyses.Count > 0)

                    maxId = _analyses.Keys.Max();

                analyse.Id = ++maxId;
            }

            _analyses.Add(analyse.Id, analyse);
        }

        public void Save()
        {
            // Ne rien faire
        }

        public void UpdateAnalyse(IAnalyse analyse)
        {
            _analyses[analyse.Id] = analyse;
        }
    }
}
