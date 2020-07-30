using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoComSenha.Models
{
    public class TableFromPdf
    {
        string _filePath = @"C:\Users\pedrin\Documents\acoes.pdf";
        public List<Acao> Read()
        {
            var pdfReader = new PdfReader(_filePath);
            var pages = new List<String>();
            List<Acao> acoes = new List<Acao>();

            for (int i = 0; i < pdfReader.NumberOfPages; i++)
            {
                string textFromPage = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Default, Encoding.UTF8, pdfReader.GetPageContent(i + 1)));

                pages.Add(GetDataConvertedData(textFromPage, acoes));
            }

            //return pages;
            return acoes;
        }

        string GetDataConvertedData(string textFromPage, List<Acao> acoes)
        {
            Acao acao = new Acao();

            var texts = textFromPage.Split(new[] { "\n" }, StringSplitOptions.None)
                                    .Where(text => text.Contains("Tj")).ToList();
            int AcaoId = 1;
            int controller = 0;
            foreach (var text in texts)
            {
                if (text == "(02)Tj")
                {
                    if (acao.AcaoName != null)
                    {
                        if (acao.AcaoQuatidade != null && acao.AcaoValor != null)
                        {
                            acao.AcaoPreco = (Convert.ToString(((Convert.ToDouble(acao.AcaoValor)) / (Convert.ToDouble(acao.AcaoQuatidade))).ToString("F2")));
                        }

                        acao.AcaoID = AcaoId;

                        acoes.Add(acao);
                        acao = new Acao();

                        controller = 0;
                        AcaoId++;

                        continue;
                    }

                    controller = 0;
                    acao = new Acao();
                    continue;
                }
                else if (text == "( )Tj")
                {
                    controller++;
                    continue;
                }
                else if (controller == 5)
                {
                    //R$
                    acao.AcaoValor = text.Replace("(","").Replace(")Tj","");
                    continue;
                }
                else if (controller == 4)
                {
                    //nº de ações
                    acao.AcaoQuatidade = text.Replace("(", "").Replace(")Tj", "");
                    continue;
                }
                else if (controller == 3)
                {
                    //nº de ações
                    acao.AcaoTipo = text.Replace("(", "").Replace(")Tj", "");
                    continue;
                }
                else if (controller == 2)
                {
                    //nome da empres
                    acao.AcaoEmpresa = text.Replace("(", "").Replace(")Tj", "");
                    continue;
                }
                else if (controller == 1)
                {
                    //nome da ação
                    acao.AcaoName = text.Replace("(", "").Replace(")Tj", "");
                    continue;
                }
            }

            return texts.Aggregate(string.Empty, (current, t) => current +
                       t.TrimStart('(')
                        .TrimEnd('j')
                        .TrimEnd('T')
                        .TrimEnd(')'));
        }

    }
}
