namespace Reservator.Models
{
    public class Restaurant:BaseEntity
    {
        public string Name { get; set; }
        public Town Town { get; set; }
        public string Address { get; set; }
        public string MainPic { get; set; }
        public string Pictures { get; set; }
        public int Rating { get; set; }

        public virtual ICollection<Place> Places { get; set; } = new HashSet<Place>();
    }

}
