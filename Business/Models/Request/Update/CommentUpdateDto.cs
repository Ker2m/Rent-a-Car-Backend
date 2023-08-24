using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class CommentUpdateDto
    {
        public int user_id { get; set; } = default!;
        public int Car_id { get; set; } = default!;
        public string comment_title { get; set; } = default!;
        public string comment { get; set; } = default!;
        public int star_point { get; set; } = default!;
    }
}
