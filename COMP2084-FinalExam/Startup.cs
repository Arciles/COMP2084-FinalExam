using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP2084_FinalExam.Startup))]
namespace COMP2084_FinalExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
