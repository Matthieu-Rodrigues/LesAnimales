using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LesAnimales.Models
{
    public interface IOffreRepository
    {
        IEnumerable<Offre> AllOffres { get; }
        Offre GetById(int id);
        void Save(Offre offre);
    }
}
