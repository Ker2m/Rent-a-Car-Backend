 using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Comment : Entity<int>
    {
        public int user_id { get; set; } = default!; //User tablosundan user id ile ilişkilendirilecek
        public int Car_id { get; set; } = default!; //Car tablosundan car id ile ilişkilendirilecek
        public string comment_title { get; set; } = default!;
        public string comment { get; set; } = default!;
        public int star_point { get; set; } = default!;

        //REFERANSLAR
        public User User { get; set; }
        public Cars Cars { get; set; }
    }
}

