using Infraestructure.Data;
using SchoolArrival.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolArrival.Infrastructure.Data;
// <T> : tipo generico que prtmite que la clase funcione con cualquier clase sin recibir repositorios separados 
public class EfRepository<T> : RepositoryBase<T> where T : class //EfRepository es un repo generico que sirve para reutilizar code para cualquier entidad
// codigo mas legible y ordenado, no repite code: sin heredar todos los repos. tiene todos los metdos, usas solo los que necesites. 
{
    // baja la base de datos y la guarda en _context
    // protected sirve para no estar repitiendo codigo y que las clases hijas de EfRepository puedan acceder al context / BD
    protected readonly TravelArrivalDbContext _context;
    public EfRepository(TravelArrivalDbContext dbContext) : base(dbContext)
    {
        _context = dbContext;
    }
}
