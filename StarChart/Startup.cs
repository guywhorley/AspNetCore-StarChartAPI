using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using StarChart.Data;


namespace StarChart
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			// Declare that I am going to use MVC framework
			services.AddMvc();
			// Declare that I am going to  use an in-memory DbContext (nec' for EntityFramework)
			services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("Starchart"));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			// Configuring Request Pipeline to use MVC
			app.UseMvc();
		}
	}
}
