using LaboratoireData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoireData
{
    public interface ILaboratoireRepository
    {
        IEnumerable<IAnalyse> GetAnalyses();
        IAnalyse GetAnalyseByID(int analyseId);
        void InsertAnalyse(IAnalyse analyse);
        void DeleteAnalyse(int analyseID);
        void UpdateAnalyse(IAnalyse analyse);
        void Save();
    }
}
