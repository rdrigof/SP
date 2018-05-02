using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ISIVIC.SP.Bo.Abstractions;
using ISIVIC.SP.Bo.Basesistema;
using NCH.Fwk.Configuration;
using NCH.Fwk.DependencyInjection;
using NCH.Fwk.DependencyInjection.Abstractions;

namespace ISIVIC.SP.UI.Host
{
    public static class DependencyResolverConfigurator
    {
        private static readonly String BaseUrl = Settings.CTAServicesHostUrl;

        public static void RegisterComponents()
        {
            var dependencyInjectionEngine = new DependencyInjectionEngine();
            var dependencyResolver = dependencyInjectionEngine.GetWebApiDependencyResolver();

            RegisterTypes(dependencyResolver);

            GlobalConfiguration.Configuration.DependencyResolver = dependencyResolver;
        }

        private static void RegisterTypes(ITypeRegistrator dependencyResolver)
        {
            //Lista menus
            dependencyResolver.RegisterType<ISP_CONS_MENUS_USUARIOS_ASIGNADOS_BO, SP_CONS_MENUS_USUARIOS_ASIGNADOS_BO>();
            dependencyResolver.RegisterType<ISP_CONS_MENUS_USUARIOS_NO_ASIGNADOS_BO, SP_CONS_MENUS_USUARIOS_NO_ASIGNADOS_BO>();

            var client = GetHttpClient();
            dependencyResolver.RegisterInstance(client);
        }

        private static HttpClient GetHttpClient()
        {
            var client = new HttpClient { BaseAddress = new Uri($"{BaseUrl}/api/") };
            return client;
        }
    }
}