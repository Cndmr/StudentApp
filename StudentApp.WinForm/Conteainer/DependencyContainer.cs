using Microsoft.Extensions.DependencyInjection;
using StudentApp.WinForm.Interfaces;
using StudentApp.WinForm.Repositories;

namespace StudentApp.WinForm.Conteainer
{
    public class DependencyContainer
    {
        ServiceProvider serviceProvider;
        public DependencyContainer()
        {
            serviceProvider = new ServiceCollection()
                .AddScoped<IGenderRepository, GenderRepository>()
                .AddScoped<IInstructorRepository, InstructorRepository>()
                .AddScoped<IAppUserRepository,AppUserRepository>()
                .BuildServiceProvider();
        }
        public IGenderRepository GetGenderRepositoryInstance()
        {
            return
                  serviceProvider.GetRequiredService<IGenderRepository>();
        }
        public IInstructorRepository GetInstructorRepositoryInstance()
        {
            return
                serviceProvider.GetRequiredService<IInstructorRepository>();
        }
        public IAppUserRepository GetAppUserRepositoryInstance()
        {
            return
                serviceProvider.GetRequiredService<IAppUserRepository>();
        }
    }
}
