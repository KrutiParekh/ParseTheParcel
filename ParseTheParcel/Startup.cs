using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParseTheParcel.Startup))]
namespace ParseTheParcel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
