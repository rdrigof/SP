using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(ISIVIC.SP.UI.Host.Startup))]
namespace ISIVIC.SP.UI.Host
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}