using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstruturaOrganizacional.Domain;

namespace EstruturaOrganizacional.Persistence.Contratos
{
    public interface IGeralPersist
    {
        //GERAL
        void Add<T> (T Entity) where T: class;
        void Update<T> (T Entity) where T: class;
        void Delete<T> (T Entity) where T: class;
        void DeleteRange<T> (T[] Entity) where T: class;
        Task<bool> SaveChangesAsyncs();

        
    }
}