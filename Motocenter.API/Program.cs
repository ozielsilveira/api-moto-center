using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using MotoCenter.Application.Mapping;
using MotoCenter.Infrastructure.Context.v1;

namespace MotoCenter.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Specify the correct AddAutoMapper method
            builder.Services.AddAutoMapper(
                typeof(MappingProfile)
            );

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MotoCenter API", Version = "v1" });
            });

            // Adicionar serviços ao contêiner.
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            // Add CORS policy
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger(); // Ativa o Swagger em desenvolvimento
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MotoCenter API v1")); // Configura o Swagger UI
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Use CORS policy
            app.UseCors("AllowAll");

            app.UseAuthorization();

            app.MapControllers();

            await app.RunAsync();
        }
    }
}
