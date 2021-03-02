using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Psi.Domain.Entities;
using Psi.Domain.Interfaces;
using Psi.Domain.Models;
using Psi.Domain.Models.Validators;
using Psi.Infra.Data.Context;
using Psi.Infra.Data.Repository;

namespace Psi.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public static IConfiguration StaticConfig { get; private set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            StaticConfig = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;
                options.SignIn.RequireConfirmedEmail = true;
            })
          .AddEntityFrameworkStores<AppDBContext>()
          .AddDefaultTokenProviders();

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services
               .AddMvc()
               .AddFluentValidation(options =>
               {
                   options.RegisterValidatorsFromAssemblyContaining<CreateTesteModelValidator>();
               });

            services
                .AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddInMemoryIdentityResources(Config.IdentityResources)
                .AddInMemoryClients(Config.Clients)
                .AddInMemoryApiResources(Config.Apis)
                .AddAspNetIdentity<ApplicationUser>();

            services.AddLocalApiAuthentication();
            services.AddControllers().AddNewtonsoftJson();

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile(new DomainToViewModelProfile());
            //    cfg.AddProfile(new ViewModelToDomainProfile());
            //});
            //IMapper mapper = config.CreateMapper();
            //services.AddSingleton(mapper);

            //Add Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "API - ClinicPsi",
                        Version = "v1",
                        Contact = new OpenApiContact
                        {
                            Name = "Ayslan Alves",
                            Url = new System.Uri("https://github.com/ayslan")
                        }
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("MyPolicy");

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                // auto migration
                context.Database.Migrate();

                // Seed the database.
                //InitializeUserAndRoles(context);
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseIdentityServer();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API - ClinicPsi");
            });
        }
    }
}
