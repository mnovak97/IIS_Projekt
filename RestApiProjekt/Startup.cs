using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using RestApiProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiProjekt
{
    public class Startup
    {
        internal static List<Kupac> PopisKupaca;
        internal static List<Korisnik> PopisKorisnika;
        internal static List<RadniNalog> PopisRadnihNaloga;
        internal static List<Usluga> PopisUsluga;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            PopisKupaca = new List<Kupac>();
            PopisKorisnika = new List<Korisnik>();
            PopisRadnihNaloga = new List<RadniNalog>();
            PopisUsluga = new List<Usluga>();

            
            Korisnik admin = new Korisnik("Admin", "Dovla", "lozinka123");
            PopisKorisnika.Add(admin);
            Usluga klima = new Usluga("A-44", "Popravak klime", 1, 149.99);
            Usluga punjenje = new Usluga("A-43", "Punjenje klime", 1, 100.00);
            PopisUsluga.Add(klima);
            PopisUsluga.Add(punjenje);
            //RadniNalog nalog = new RadniNalog(admin.IDKorisnik,kupac.IDKupac,249.99,true,true,PopisUsluga);
            //PopisRadnihNaloga.Add(nalog);

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers().AddXmlDataContractSerializerFormatters();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RestApiProjekt", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RestApiProjekt v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
