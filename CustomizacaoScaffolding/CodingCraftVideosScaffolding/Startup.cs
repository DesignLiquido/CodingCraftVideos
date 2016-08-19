using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodingCraftVideosScaffolding.Startup))]
namespace CodingCraftVideosScaffolding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
