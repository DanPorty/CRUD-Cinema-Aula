using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace CinemaTest
{
    public partial class MyDBContext : DbContext
    {
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Sessao> Sessao { get; set; }
        public DbSet<Ingresso> Ingresso { get; set; }
        public DbSet<IngressoItem> IngressoItem { get; set; }

        public MyDBContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var server = "localhost";
            var port = "5432";
            var username = "postgres";
            var password = "ifsp";
            var database = "CinemaDB";
            var conStr = $"Host={server};Port={port};Username={username};Password={password};Database={database}";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(conStr);
            }
        }
    }

    [TestClass]
    public class TestCinemaRepository
    {
        [TestMethod]
        public void CriarBanco()
        {
            using (var db = new MyDBContext())
            {
                Assert.IsNotNull(db);
            }
        }

        [TestMethod]
        public void InsertGenero()
        {
            using (var db = new MyDBContext())
            {
                var genero1 = new Genero() { Id = 1, Nome = "Comédia" };
                var genero2 = new Genero() { Id = 2, Nome = "Terror" };
                var genero3 = new Genero() { Id = 3, Nome = "Ação" };

                db.Genero.Add(genero1);
                db.Genero.Add(genero2);
                db.Genero.Add(genero3);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void ListarGerenero()
        {
            using (var db = new MyDBContext())
            {
                foreach (var item in db.Genero)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
            }
        }

        [TestMethod]
        public void InsertFilme()
        {
            using (var db = new MyDBContext())
            {
                var genero = new Genero() { Nome = "Ação" };

                var filme = new Filme()
                {
                    Nome = "Matrix",
                    Duracao = 136,
                    Classificacao = "14",
                    Genero = genero
                };

                db.Filme.Add(filme);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void InsertSala()
        {
            using (var db = new MyDBContext())
            {
                var sala = new Sala()
                {
                    Numero = 1,
                    Capacidade = 100,
                    Fileiras = 10,
                    Assentos = 10
                };

                db.Sala.Add(sala);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void InsertSessao()
        {
            using (var db = new MyDBContext())
            {
                var genero = new Genero() { Nome = "Ação" };
                var filme = new Filme() { Nome = "Vingadores", Duracao = 143, Classificacao = "12", Genero = genero };
                var sala = new Sala() { Numero = 2, Capacidade = 80, Fileiras = 8, Assentos = 10 };

                var sessao = new Sessao()
                {
                    Data = DateTime.Now.AddDays(1),
                    Preco = 32.50m,
                    Filme = filme,
                    Sala = sala
                };

                db.Sessao.Add(sessao);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void InsertIngresso()
        {
            using (var db = new MyDBContext())
            {
                var genero = new Genero() { Nome = "Aventura" };
                var filme = new Filme() { Nome = "Avatar", Duracao = 162, Classificacao = "12", Genero = genero };
                var sala = new Sala() { Numero = 1, Capacidade = 50, Fileiras = 5, Assentos = 10 };
                var sessao = new Sessao() { Data = DateTime.Now, Preco = 30.00m, Filme = filme, Sala = sala };

                var ingresso = new Ingresso()
                {
                    DataCompra = DateTime.Now,
                    Documento = "123.456.789-00",
                    FormaPagamento = "PIX",
                    ValorTotal = 30.00m,
                    Sessao = sessao,
                    IngressoItens = new List<IngressoItem>()
                    {
                        new IngressoItem()
                        {
                            Fileira = 4,
                            Assento = 12,
                            MeiaEntrada = false
                        }
                    }
                };

                db.Ingresso.Add(ingresso);
                db.SaveChanges();
            }
        }
    }
}