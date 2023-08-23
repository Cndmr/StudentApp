using Microsoft.Extensions.DependencyInjection;
using StudentApp.WinForm.Interfaces;
using StudentApp.WinForm.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.WinForm.Conteainer
{
    public class DependencyContainer
    {
        ServiceProvider serviceProvider;
        public DependencyContainer()
        {
          serviceProvider=  new ServiceCollection().AddScoped<IGenderRepository, GenderRepository>().BuildServiceProvider();
        }
        public IGenderRepository GetGenderRepositoryInstance()
        {
          return
                serviceProvider.GetRequiredService<IGenderRepository>();
        }
    }
}
