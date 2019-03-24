using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiSolutions_Xamarin.Startup))]
namespace ServiSolutions_Xamarin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
