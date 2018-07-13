using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Infrastructure
{
    /// <summary>
    /// Attraverso la UnitOfWork, il service richiedere i dati effettuando una commit tramite questa interfaccia
    /// In tal modo evitiamo che contatti direttamente il Repository
    /// </summary>
    public interface IUnitOfWork
    {
        void Commit();
    }
}
