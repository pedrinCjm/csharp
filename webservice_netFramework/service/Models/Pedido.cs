using System.Collections.Generic;

namespace cliente.Models
{
    public class Pedido
    {

        public string OrdemServico { get; set; }

        public string Observacao { get; set; }
    }

    public class Endereco
    {

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Tipo { get; set; }
    }

    public class Paciente
    {
        public Paciente()
        {
            Enderecos = new HashSet<Endereco>();
        }

        public string UsuarioWeb { get; set; }

        public string SenhaWeb { get; set; }

        public string Codigo { get; set; }

        public string Nome { get; set; }

        public string Sexo { get; set; }

        public string DtNascimento { get; set; }

        public string Altura { get; set; }

        public string Peso { get; set; }

        public string Dum { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public string Cns { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Medicamento { get; set; }

        public virtual HashSet<Endereco> Enderecos { get; set; }

        public string Anamnese { get; set; }
    }

    public class InformacaoPreAnalitica
    {

        public string Identificador { get; set; }

        public string Valor { get; set; }
    }

    public class Amostra
    {
        public string CodigoBarra { get; set; }
        public string Recipiente { get; set; }
        public string Etiqueta { get; set; }
    }

    public class Medico
    {

        public string Nome { get; set; }

        public string Crm { get; set; }

        public string Conselho { get; set; }

        public string Uf { get; set; }
    }


    public class Exame
    {
        public Exame()
        {
            InformacoesPreAnaliticas = new HashSet<InformacaoPreAnalitica>();
            Amostras = new HashSet<Amostra>();
            Medicos = new HashSet<Medico>();
        }
        public string Codigo { get; set; }

        public string CodigoApoio { get; set; }

        public string CodigoLISOrigem { get; set; }

        public string SequencialComplementar { get; set; }

        public string Descricao { get; set; }

        public virtual HashSet<InformacaoPreAnalitica> InformacoesPreAnaliticas { get; set; }

        public virtual HashSet<Amostra> Amostras { get; set; }

        public string DescMaterial { get; set; }

        public virtual HashSet<Medico> Medicos { get; set; }

        public string Urgente { get; set; }
    }

    public class PedidoLab
    {
        public PedidoLab()
        {
            Exames = new HashSet<Exame>();

        }

        public Pedido Pedido { get; set; }

        public Paciente Paciente { get; set; }

        public virtual HashSet<Exame> Exames { get; set; }
    }


    public class ImportaPedido
    {
        public ImportaPedido()
        {
            ListaPedidoLab = new HashSet<PedidoLab>();

        }

        public string IdLaboratorio { get; set; }
        public string Senha { get; set; }

        public virtual HashSet<PedidoLab> ListaPedidoLab { get; set; }
    }

    public class RetornoLab
    {
        public RetornoLab()
        {
            Exames = new HashSet<Exame>();

        }

        public string Pedido { get; set; }
        public string OrdemServico { get; set; }
        public virtual HashSet<Exame> Exames { get; set; }
        public bool Retorno { get; set; }
        public string DescErro { get; set; }
    }

    public class ListaRetornoLab
    {
        public ListaRetornoLab()
        {
            RetornoLab = new HashSet<RetornoLab>();

        }

        public HashSet<RetornoLab> RetornoLab { get; set; }
    }

    public class PRetornoCliente
    {
        public ListaRetornoLab ListaRetornoLab { get; set; }
    }
}