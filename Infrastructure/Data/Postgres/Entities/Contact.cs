using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Contact : Entity<int>
    {
        public string name { get; set; } = default!;
        public string email { get; set; } = default!;
        public string subject { get; set; } = default!;
        public string message { get; set; } = default!;
    }
}
