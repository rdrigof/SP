using Owin;
using System;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using NCH.Fwk.Configuration;

namespace ISIVIC.SP.UI.Host
{
    public partial class Startup
    {
        /// <summary>
        /// OAuthOptions
        /// </summary>

        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        /// <summary>
        /// PublicClientId
        /// </summary>
        public static string PublicClientId { get; private set; }

        /// <summary>
        /// ConfigureAuth
        /// </summary>
        /// <param name="app">app</param>
        public void ConfigureAuth(IAppBuilder app)
        {

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationMode = AuthenticationMode.Active,
                ExpireTimeSpan = new TimeSpan(0, 15, 0),
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                CookieHttpOnly = true,
                CookieSecure = CookieSecureOption.SameAsRequest,
                CookiePath = "/",
                CookieName = "EHMT",
                CookieDomain = Settings.Domain,
            });

            app.SetDefaultSignInAsAuthenticationType(DefaultAuthenticationTypes.ApplicationCookie);
        }
    }
}