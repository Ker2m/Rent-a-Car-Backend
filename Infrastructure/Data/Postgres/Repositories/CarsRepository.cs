using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Infrastructure.Data.Postgres.Repositories;

public class CarsRepository : Repository<Cars, int>, ICarsRepository
{
    public CarsRepository(PostgresContext postgresContext) : base(postgresContext)
    {
    }

    public async Task<IList<Cars>> GetAllAsync(Expression<Func<Cars, bool>>? filter = null)
    {
        var cars = PostgresContext.Set<Cars>();
        return filter == null
            ? await cars.ToListAsync()
            : await cars.Where(filter)
            .ToListAsync();
    }

    public Task<IList<Cars>> GetByCarsIdAsync()
    {
        throw new NotImplementedException();
    }
}