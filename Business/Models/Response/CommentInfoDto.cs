using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class CommentInfoDto
    {
        public int Id { get; set; }
        public int user_id { get; set; } = default!; //User tablosundan user id ile ilişkilendirilecek
        public int Car_id { get; set; } = default!; //Car tablosundan car id ile ilişkilendirilecek
        public string comment_title { get; set; } = default!;
        public string comment { get; set; } = default!;
        public int star_point { get; set; } = default!;

        //Kullanıcı ve araç bilgilerine ulaşmak için nesne oluşturduk
        public UserProfileDto User { get; set; }
        public CarInfoDto Cars { get; set; }
    }
}
