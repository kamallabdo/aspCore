using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo5.Services
{
    public interface IEtudiantService
    {
        void Save(Models.Etudiant e);
        IEnumerable<Models.Etudiant> FindAll();
        Models.Etudiant GetEtudiantById(int id);
    }
}
