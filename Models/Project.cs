namespace Portfolio.Models
{
    public class Project
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
        public List<string> Achievements { get; set; }
        public List<string> TestingScope { get; set; }
        public bool Confidential { get; set; }
        public string LiveUrl { get; set; }
    }
}
