namespace Lumia.Models
{
    public class AboutDetail
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Detail { get; set; }
        public int AboutId { get; set; }
        public About About { get; set; }
    }
}
