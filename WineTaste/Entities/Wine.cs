namespace WineTaste.Entities
{
    public class Wine
    {
        public int WineId { get; set; }
        public int VarietalId { get; set; }
        public string WineName { get; set; }
        public string WineRegion { get; set; }
        public double WinePrice { get; set; }
        public string WineImage { get; set; }
        public string WineDescription { get; set; }
        public int WineYear { get; set; }
        public double WineRating { get; set; }
        public string WineReview { get; set; }
    }
}