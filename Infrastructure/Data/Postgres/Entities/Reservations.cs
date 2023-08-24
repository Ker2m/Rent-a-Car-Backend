using Infrastructure.Data.Postgres.Entities.Base;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Reservations : Entity<int>
    {
        public int User_id { get; set; } = default!;

        public int Car_id { get; set; } = default!;

        public string Car_pickup_location { get; set; } = default!;

        public string Car_dropoff_location { get; set; } = default!;

        //public int hour { get; set; } = default!;

        public string  Pick_Up_Date { get; set; } = default!;
        public string Choose_A_Date { get; set; } = default!;


        //REFERANSLAR

        public User User { get; set; }

        public Cars Cars { get; set; }

        

        //validition eklenecek.
    }
}
