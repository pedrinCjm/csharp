using System.Web.Mvc;

namespace cliente.Controllers
{
    using application.webservice_connection;
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ws = new service();
            var listaJogosModelView = new ListaJogosModelView();

            listaJogosModelView = ws.AcessaJogos();

            return View(listaJogosModelView);
        }

        public ActionResult RetornoPedido()
        {
            var ws = new service();
            var listaJogosModelView = new ListaJogosModelView();
            var importaPedido = new ImportaPedido();
            var pRetornoCliente = new PRetornoCliente();

            PedidoLab[] pedidoLab = new PedidoLab[1];
            Pedido pedido = new Pedido();
            Paciente paciente = new Paciente();
            Endereco endereco = new Endereco();
            Endereco[] enderecos = new Endereco[1];
            Exame[] exames = new Exame[1];
            Exame exame = new Exame();
            Amostra[] amostras = new Amostra[1];
            Amostra amostra = new Amostra();
            InformacaoPreAnalitica[] informacoesPreAnaliticas = new InformacaoPreAnalitica[1];
            InformacaoPreAnalitica informacaoPreAnalitica = new InformacaoPreAnalitica();
            Medico[] medicos = new Medico[1];
            Medico medico = new Medico();

            // pedido
            pedido.OrdemServico = "123487";
            pedido.Observacao = "PEDIDO TESTE";

            // endereços
            endereco.Cep = "150000";
            endereco.Bairro = "CENTRO";
            endereco.Cidade = "SÃO PAULO";
            endereco.Estado = "SP";
            endereco.Logradouro = "RUA CENTRAL";
            endereco.Numero = "100";
            endereco.Complemento = "CASA";
            endereco.Tipo = "1";
            enderecos[0] = endereco;

            // paciente
            paciente.UsuarioWeb = "user";
            paciente.SenhaWeb = "senha";
            paciente.Codigo = "99998";
            paciente.Nome = "Larissa";
            paciente.Sexo = "M";
            paciente.DtNascimento = "1990-01-01";
            paciente.Altura = "1,53";
            paciente.Peso = "80";
            paciente.Dum = "não sei o que é";
            paciente.Rg = "4424242421";
            paciente.Cpf = "4424242421";
            paciente.Cns = "4424242421";
            paciente.Email = "email@email.com";
            paciente.Telefone = "999999999";
            paciente.Celular = "999999999";
            paciente.Medicamento = "dipirona";
            paciente.Anamnese = "Anamnese";
            paciente.Enderecos = enderecos;

            // medicos
            medico.Nome = "LUCIANA JUNQUEIRA GUIMARAES";
            medico.Crm = "113701";
            medico.Conselho = "06";
            medico.Uf = "SP";
            medicos[0] = medico;

            // amostras
            amostra.CodigoBarra = "20000020460";
            amostra.Recipiente = "Recipiente";
            amostras[0] = amostra;

            // informacaoPreAnaliticas


            // exames
            exame.Codigo = $"COVID-19200000001";
            exame.CodigoLISOrigem = $"TGO1";
            exame.Descricao = $"Texto de descricao blablabla";
            exame.DescMaterial = $"Texto de descricao do material blablabla";
            exames[0] = exame;

            pedidoLab[0].Exames = exames;
            pedidoLab[0].Paciente = paciente;

            importaPedido.ListaPedidoLab = pedidoLab;

            pRetornoCliente = ws.ImportaPedidoCliente(importaPedido);

            return View(pRetornoCliente);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}