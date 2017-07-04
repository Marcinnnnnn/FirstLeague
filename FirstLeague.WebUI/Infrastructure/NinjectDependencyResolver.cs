using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ninject;
using Moq;
using FirstLeague.Domain.Abstract;
using FirstLeague.Domain.Entities;
using FirstLeague.Domain.Concrete;

namespace FirstLeague.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //Mock<ITeamRepository> mock = new Mock<ITeamRepository>();
            //mock.Setup(m => m.Teams).Returns(new List<Team> {
            //    new Team { Name = "Legia", Score = 40},
            //    new Team { Name ="Lech", Score = 10 }
            //    });

            //kernel.Bind<ITeamRepository>().ToConstant(mock.Object);                
            kernel.Bind<ITeamRepository>().To<EFTeamRepository>();
        }
    }
}