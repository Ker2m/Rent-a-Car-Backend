using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CarCreateDto
    {
        public string arac_adi { get; set; } = default!;
        public string arac_resmi { get; set; } = default!;
        public string vites_tipi { get; set; } = default!;
        public string yakit_tipi { get; set; } = default!;
        public int arac_kilometre { get; set; } = default!;
        public string arac_tipi { get; set; } = default!;
        public int arac_koltuk { get; set; } = default!;
        public string arac_popularite { get; set; } = default!;
        public int price { get; set; } = default!;
    }
}
