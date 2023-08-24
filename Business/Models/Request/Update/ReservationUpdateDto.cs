using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class ReservationUpdateDto
    {
        public int User_id { get; set; } = default!;

        public int Car_id { get; set; } = default!;

        public string Car_pickup_location { get; set; } = default!;

        public string Car_dropoff_location { get; set; } = default!;

        //public int hour { get; set; } = default!;

        public string Pick_Up_Date { get; set; } = default!;
        public string Choose_A_Date { get; set; } = default!;
    }
}
