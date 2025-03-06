namespace PortfolioProject.Models.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Technologies { get; set; }
        public required string GitHubLink { get; set; }
        public required string LiveDemoLink { get; set; }
    }
}
