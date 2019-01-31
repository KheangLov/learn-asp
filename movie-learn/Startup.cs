using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(movie_learn.Startup))]
namespace movie_learn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
