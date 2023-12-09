namespace MyWeb.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public Blog(string title, string picture, string pictureAlt, string pictureTitle, string shortDescription, string description)
        {
            Title = title;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ShortDescription = shortDescription;
            Description = description;
        }
    }
}
