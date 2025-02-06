using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BasicMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Bu metot, uygulama için gerekli servisleri yapılandırır.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // MVC özelliklerini ekliyoruz
        }

        // Bu metot, HTTP istekleri için uygulamanın nasıl işleyeceğini yapılandırır.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Geliştirme ortamında hata sayfası gösterir
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts(); // HSTS (HTTP Strict Transport Security)
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles(); // Statik dosyalar (CSS, JS, resimler vb.)

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Uygulama, belirtilen route'a göre yönlendirilecek
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=CustomerOrders}/{action=Index}/{id?}");
            });
        }
    }
}
