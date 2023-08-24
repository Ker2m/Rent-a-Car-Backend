using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class ReservationsRepository : Repository<Reservations, int>, IReservationsRepository
    {
        public ReservationsRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        //public async Task<IList<Reservations>> GetAllAsync(Expression<Func<Reservations, bool>>? filter = null)
        //{
        //    var reservations = PostgresContext.Set<Reservations>().Include(Reservations => Reservations.Id);
        //    return filter == null
        //        ? await reservations.ToListAsync()
        //        : await reservations.Where(filter)
        //        .ToListAsync();
        //}
        public async Task<IList<Reservations>> GetAllAsync(Expression<Func<Reservations, bool>>? filter = null)
        {
            IQueryable<Reservations> reservationsQuery = PostgresContext.Set<Reservations>();

            if (filter != null)
            {
                reservationsQuery = reservationsQuery.Where(filter);
            }

            var reservations = await reservationsQuery
                .Include(r => r.User)
                .Include(r => r.Cars)
                .ToListAsync();

            return reservations;
        }
        public Task<IList<Reservations>> GetByReservationsIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
