using Microsoft.EntityFrameworkCore;
using SenaiApi.Repository.Contexts;
using SenaiApi.Repository.Interfaces;
using SenaiApi.Repository.Repositorios;
using SenaiApi.Service.Interface;
using SenaiApi.Service.Service;

namespace SenaiApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(); 

            #region Injeção de Dependência

            builder.Services.AddScoped<IPessoaService, PessoaService>();
            builder.Services.AddScoped<IPessoaRepository, PessoaRepositorio>();

            builder.Services.AddDbContext<ApiContext>(options =>
            options.UseNpgsql(builder.Configuration.GetValue<string>("ConnectionStrings:ApiSenai")));
            #endregion

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}