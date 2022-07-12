using System.Collections.Generic;

namespace Lumia.Models
{
    public class Testimonial
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }
        public int CommentId { get; set; }

    }
}
