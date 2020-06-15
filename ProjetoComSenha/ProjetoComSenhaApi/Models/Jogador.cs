namespace ProjetoComSenhaApi.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }
        public string NoJogador { get; set; }
        public string NickJogador { get; set; }
        public virtual HistoricoPartida HistoricoPartidas { get; set; }
    }
}
