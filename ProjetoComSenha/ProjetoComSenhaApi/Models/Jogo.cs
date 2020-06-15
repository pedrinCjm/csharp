namespace ProjetoComSenhaApi.Models
{
    public class Jogo
    {
        public int JogoId { get; set; }
        public string NoJogo { get; set; }
        public string DsJogo { get; set; }
        public int TipoJogoId { get; set; }
        public virtual TipoJogo TipoJogo { get; set; }
    }
}
