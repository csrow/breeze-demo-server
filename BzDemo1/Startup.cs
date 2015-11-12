using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BzDemo1.Startup))]

namespace BzDemo1
{
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
    }
  }
}
