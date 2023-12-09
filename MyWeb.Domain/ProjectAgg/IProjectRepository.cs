namespace MyWeb.Domain.ProjectAgg
{
    public interface IProjectRepository
    {
        void Create(Project project);
        void SaveChanges();
    }
}
