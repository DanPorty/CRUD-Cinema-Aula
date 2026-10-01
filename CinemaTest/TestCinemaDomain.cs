using System.Diagnostics;
using System.Text.Json;
using CinemaDomain;

namespace CinemaTest
{
    [TestClass]
    public sealed class TestCinemaDomain
    {
        private JsonSerializerOptions OptionsJson()
        {
            return new JsonSerializerOptions { WriteIndented = true };
        }

        [TestMethod]
        public void TestGenero()
        {
            var genero = new Genero
            {
                Id = 1,
                Nome = "Suspense"
            };

            var generoJson = JsonSerializer.Serialize(genero, OptionsJson());
            Debug.WriteLine(generoJson);
            Assert.IsNotNull(generoJson);
        }

        [TestMethod]
        public void TestFilme()
        {
            var genero = new Genero { Id = 1, Nome = "Acao" };

            var filme = new Filme
            {
                Id = 1,
                Nome = "LEGO Batman",
                Classificacao = "Livre",
                Genero = genero,
                Duracao = 120
            };

            var filmeJson = JsonSerializer.Serialize(filme, OptionsJson());
            Debug.WriteLine(filmeJson);
            Assert.IsNotNull(filmeJson);
        }

        [TestMethod]
        public void TestSala()
        {
            var sala = new Sala
            {
                Id = 1,
                Numero = 1,
                Capacidade = 100,
                Fileiras = 10,
                Assentos = 10
            };

            var salaJson = JsonSerializer.Serialize(sala, OptionsJson());
            Debug.WriteLine(salaJson);
            Assert.IsNotNull(salaJson);
        }

        [TestMethod]
        public void TestSessao()
        {
            var genero = new Genero { Id = 1, Nome = "Acao" };
            var filme = new Filme
            {
                Id = 1,
                Nome = "LEGO Batman",
                Classificacao = "Livre",
                Genero = genero,
                Duracao = 120
            };
            var sala1 = new Sala
            {
                Id = 1,
                Numero = 1,
                Capacidade = 100,
                Fileiras = 10,
                Assentos = 10
            };

            var sessao = new Sessao
            {
                Id = 1,
                Filme = filme,
                Data = DateTime.Now,
                Sala = sala1,
                Preco = 20.0m
            };

            var sessaoJson = JsonSerializer.Serialize(sessao, OptionsJson());
            Debug.WriteLine(sessaoJson);
            Assert.IsNotNull(sessaoJson);
        }

        [TestMethod]
        public void TestIngressoItem()
        {
            var item = new IngressoItem
            {
                Fileira = 5,
                Assento = 12,
                MeiaEntrada = true
            };

            var itemJson = JsonSerializer.Serialize(item, OptionsJson());
            Debug.WriteLine(itemJson);
            Assert.IsNotNull(itemJson);
        }

        [TestMethod]
        public void TestIngresso()
        {
            var item1 = new IngressoItem { Fileira = 3, Assento = 10, MeiaEntrada = false };
            var item2 = new IngressoItem { Fileira = 3, Assento = 11, MeiaEntrada = true };

            var ingresso = new Ingresso
            {
                Id = 1,
                DataCompra = DateTime.Now,
                Documento = "123.456.789-00",
                FormaPagamento = "Cartao",
                ValorTotal = 30.0m,
                IngressoItens = new List<IngressoItem> { item1, item2 }
            };

            var ingressoJson = JsonSerializer.Serialize(ingresso, OptionsJson());
            Debug.WriteLine(ingressoJson);
            Assert.IsNotNull(ingressoJson);
        }
    }
}
