namespace mongoFlix.API.Domain.Entities
{
    public class Movie
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Poster { get; set; }
        public string Plot { get; set; }
        public string FullPlot { get; set; }
    }
}