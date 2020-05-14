using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exo5.Models;

namespace Exo5.Services
{
    public class EtudiantServiceImp : IEtudiantService
    {
        private readonly EtudiantContext db;
        public EtudiantServiceImp(EtudiantContext context)
        {
            db = context;
        }
        public IEnumerable<Etudiant> FindAll()
        {
            return db.Etudiant.ToList();
        }

        public Etudiant GetEtudiantById(int id)
        {
            Etudiant e = db.Etudiant.Find(id);
            return e;
           
        }

        public void Save(Etudiant e)
        {
            db.Etudiant.Add(e);
            db.SaveChanges();
           
        }
    }
}
