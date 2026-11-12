
using AutoMapper;
using CinemaApp.Cadastros;
using CinemaApp.Models;
using CinemaDomain;
using CinemaRepository.Base;
using CinemaRepository.Context;
using CinemaService.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.IO;

namespace CinemaApp.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection Services;
        public static IServiceProvider ServiceProvider;

        public static void Configure()
        {
            Services = new ServiceCollection();

            #region Banco de Dados Injeção de Dependência
            var strCon = File.ReadAllText("Config/ConfigDB.txt");
            Services.AddDbContext<MyDBContext>(options => options.UseNpgsql(strCon));
            #endregion

            #region Repositórios Injeção de Dependência
            Services.AddScoped<InterfaceBaseRepository<Genero>, BaseRepository<Genero>>();
            Services.AddScoped<InterfaceBaseRepository<Filme>, BaseRepository<Filme>>();
            Services.AddScoped<InterfaceBaseRepository<Sala>, BaseRepository<Sala>>();
            Services.AddScoped<InterfaceBaseRepository<Sessao>, BaseRepository<Sessao>>();
            Services.AddScoped<InterfaceBaseRepository<Ingresso>, BaseRepository<Ingresso>>();
            #endregion

            #region Serviços Injeção de Dependência
            Services.AddScoped<InterfaceBaseService<Genero>, BaseService<Genero>>();
            Services.AddScoped<InterfaceBaseService<Filme>, BaseService<Filme>>();
            Services.AddScoped<InterfaceBaseService<Sala>, BaseService<Sala>>();
            Services.AddScoped<InterfaceBaseService<Sessao>, BaseService<Sessao>>();
            Services.AddScoped<InterfaceBaseService<Ingresso>, BaseService<Ingresso>>();
            #endregion

            #region AutoMapper Injeção de Dependência
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Genero, GeneroViewModel>().ReverseMap();
                cfg.CreateMap<Filme, FilmeViewModel>()
                    .ForMember(dest => dest.GeneroId, opt => opt.MapFrom(src => src.Genero.Id))
                    .ForMember(dest => dest.GeneroNome, opt => opt.MapFrom(src => src.Genero.Nome));
                cfg.CreateMap<Sala, SalaViewModel>().ReverseMap();
                cfg.CreateMap<Sessao, SessaoViewModel>()
                    .ForMember(dest => dest.FilmeId, opt => opt.MapFrom(src => src.Filme.Id))
                    .ForMember(dest => dest.FilmeNome, opt => opt.MapFrom(src => src.Filme.Nome))
                    .ForMember(dest => dest.SalaId, opt => opt.MapFrom(src => src.Sala.Id))
                    .ForMember(dest => dest.Classificacao, opt => opt.MapFrom(src => src.Filme.Classificacao));
                cfg.CreateMap<Ingresso, IngressoViewModel>().ReverseMap();
                cfg.CreateMap<IngressoItem, IngressoItemViewModel>().ReverseMap();
            }, NullLoggerFactory.Instance);
            #endregion

            Services.AddSingleton(mapperConfig.CreateMapper());

            Services.AddTransient<CadastroGenero, CadastroGenero>();
            Services.AddTransient<CadastroFilme, CadastroFilme>();
            Services.AddTransient<CadastroSala, CadastroSala>();
            Services.AddTransient<CadastroSessao, CadastroSessao>();

            ServiceProvider = Services.BuildServiceProvider();
        }
    }
}
