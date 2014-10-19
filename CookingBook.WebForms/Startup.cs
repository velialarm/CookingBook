using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CookingBook.WebForms.Startup))]
namespace CookingBook.WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
