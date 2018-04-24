﻿using ProjetoEstoque.Command.GrupoProduto.Handler;
using ProjetoEstoque.Infra.ControleEstoque;
using ProjetoEstoque.Infra.Interface;
using ProjetoEstoque.Infra.Public;
using ProjetoEstoque.Query.Handler;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjetoEstoque.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            //Registrando as implmementações
            typeof(ObterGrupoProdutoQueryHandler).Assembly.GetExportedTypes().Where(x => x.Namespace.EndsWith("Handler")).Where(x => x.GetInterfaces().Any())
                .ToList().ForEach(x => container.Register(x.GetInterfaces().Single(), x, Lifestyle.Transient));

            typeof(RemoverGrupoProdutoCommandHandler).Assembly.GetExportedTypes().Where(x => x.Namespace.EndsWith("Handler")).Where(x => x.GetInterfaces().Any())
                .ToList().ForEach(x => container.Register(x.GetInterfaces().Single(), x, Lifestyle.Transient));

            //Dependecy of workflow engine
            container.Register<IControleEstoqueContext, ControleEstoqueContext>(Lifestyle.Scoped);
            container.Register<IPublicContext, PublicContext>(Lifestyle.Scoped);

            // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
