namespace MyWeb.Domain.ProjectAgg
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }

        public Project(string name, string description, string image, string client)
        {
            Name = name;
            Description = description;
            Image = image;
            Client = client;
        }
    }
}