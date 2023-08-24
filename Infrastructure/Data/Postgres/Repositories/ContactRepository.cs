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
    public class ContactRepository : Repository<Contact, int>, IContactRepository
    {
        public ContactRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Contact>> GetAllAsync(Expression<Func<Contact, bool>>? filter = null)
        {
            var contact = PostgresContext.Set<Contact>().Include(Contact => Contact.Id);
            return filter == null
                ? await contact.ToListAsync()
                : await contact.Where(filter)
                .ToListAsync();
        }

        public Task<IList<Contact>> GetByContactIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
