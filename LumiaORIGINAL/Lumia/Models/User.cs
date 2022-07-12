
using System.Collections.Generic;

namespace Lumia.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
