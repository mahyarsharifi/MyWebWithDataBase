using MyWeb.Application.Contracts.Project;
using MyWeb.Domain.ProjectAgg;

namespace MyWeb.Application
{
    public class ProjectApplication : IProjectApplication
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectApplication(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void Create(CreateProject command)
        {
            var project = new Project(command.Name, command.Description, command.Client, command.Image);
            _projectRepository.Create(project);
            _projectRepository.SaveChanges();
        }
    }
}
