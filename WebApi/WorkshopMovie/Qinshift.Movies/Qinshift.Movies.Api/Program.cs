using Microsoft.EntityFrameworkCore;
using Qinshift.Movies.DataAccess;
using Qinshift.Movies.Services.Implementation;
using Qinshift.Movies.Services.Interface;
using Qinshift.Movies.Services.Helper;

namespace Qinshift.Movies.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.RegisterDbContext(connectionString);
            builder.Services.RegisterRepositories();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
