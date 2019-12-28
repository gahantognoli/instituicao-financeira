using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PontoSys.InstituicaoFinanceira.Aplicacao.Interfaces.Servicos;
using PontoSys.InstituicaoFinanceira.Aplicacao.Servicos;
using PontoSys.InstituicaoFinanceira.Dados.Contexto;
using PontoSys.InstituicaoFinanceira.Dados.Repositorios;
using PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Repositorios;
using PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Servicos;
using PontoSys.InstituicaoFinanceira.Dominio.Servicos;
using Swashbuckle.AspNetCore.Swagger;

namespace PontoSys.InstituicaoFinanceira.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<InstituicaoFinanceiraContexto>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("InstituicaoFinanceiraContexto"));
            });

            services.AddScoped<IPessoaFisicaAppService, PessoaFisicaAppService>();
            services.AddScoped<IPessoaFisicaService, PessoaFisicaService>();
            services.AddScoped<IPessoaFisicaRepositorio, PessoaFisicaRepositorio>();

            services.AddAutoMapper();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "InstituicaoFinanceiraAPI", Version = "v1" });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();

            // Ativa o Swagger UI
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "InstituicaoFinanceiraAPI V1");
                opt.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
