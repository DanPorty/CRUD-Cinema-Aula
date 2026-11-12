namespace CinemaApp.Models
{
    public class SessaoViewModel
    {
        public int Id { get; set; }
        public int FilmeId { get; set; }
        public string FilmeNome { get; set; } = string.Empty;
        public string Classificacao { get; set; } = string.Empty;
        public int SalaId { get; set; }
        public DateTime Data { get; set; }
        public decimal Preco { get; set; }
    }
}
