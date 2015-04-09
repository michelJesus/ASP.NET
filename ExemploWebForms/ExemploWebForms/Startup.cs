using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExemploWebForms.Startup))]
namespace ExemploWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
