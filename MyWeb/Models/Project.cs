namespace MyWeb.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Description { get; set; }

        public Project(string name, string picture, string pictureAlt, string pictureTitle, string description)
        {
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Description = description;
        }
    }
}
