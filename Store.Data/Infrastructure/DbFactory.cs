using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Infrastructure
{

    /// <summary>
    /// E' la classe responsabile del collegamento con il DB. In un app enterprise si possono avere più
    /// database e piu collegamenti. In tal modo , al posto di passare direttamente il DataContext al Repository
    /// creiamo un DbFactory e inniettiamo il DataContext con DependencyInjection
    /// </summary>
    public class DbFactory : Disposable, IDbFactory
    {
        StoreEntities dbContext;

        public DbFactory(StoreEntities context)
        {
            dbContext = context;
        }

        public StoreEntities Init()
        {
            return dbContext ?? (dbContext = new StoreEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
