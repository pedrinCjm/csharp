using Newtonsoft.Json;
using ProjetoComSenha.Models;
using System;
using System.Net.Http;
using Xunit;
using System.Text;
using ProjetoComSenha.Controllers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CadastroJogo
{
    public class UnitTest1
    {
        //[Fact]
        //public void Test1()
        //{
        //    Busca().Wait();
        //    //var exception = Assert.Throws<ArgumentException>(postTask);
        //    ////The thrown exception can be used for even more detailed assertions.
        //    //Assert.Equal("expected error message here", exception.Message);

        //    //Assert.Equal(1, valida);
        //}

        //private async Task Busca()
        //{
        //    Jogo jogo = new Jogo
        //    {
        //        JogoId = 1,
        //        NoJogo = "Dirt",
        //        DsJogo = "Jogo de rally",
        //        TipoJogoId = 9
        //    };

        //    var client = new HttpClient();

        //    var serializer = JsonConvert.SerializeObject(jogo);
        //    var stringContent = new StringContent(serializer, Encoding.UTF8, "application/json");

        //    //HTTP POST
        //    var postTask = await client.PostAsync("https://localhost:44307/api/" + "Jogos", stringContent);

        //    var responseContent = postTask.Content.ReadAsStringAsync().ToString();

        //    // Xunit test
        //    //Assert.Null(responseContent);
        //    Assert.Equal("0", responseContent);
        //}

        [Fact]
        public void Test2()
        {
            Jogo jogo = new Jogo
            {
                JogoId = 1,
                NoJogo = "Dirt",
                DsJogo = "Jogo de rally",
                TipoJogoId = 9
            };

            //var controller = new JogosController();

            // // Act
            // var result = controller.CreateJogoVoid(jogo);

            // Assert.Equal(1, result);

            // Assert
            //var redirectToActionResult =
            //    Assert.IsType<RedirectToActionResult>(result);
            //Assert.Equal("Home", redirectToActionResult.ControllerName);
            //Assert.Equal("Index", redirectToActionResult.ActionName);
        }

        [Fact]
        public void Test3()
        {
            // add [FromBody] in controller for test using xUnit
            Busca().Wait();
        }

        private async Task Busca()
        {
            Jogo jogo = new Jogo
            {
                //JogoId = 1,
                NoJogo = "Dirt",
                DsJogo = "Jogo de rally",
                TipoJogoId = 2
            };

            var client = new HttpClient();

            var serializer = JsonConvert.SerializeObject(jogo);
            var stringContent = new StringContent(serializer, Encoding.UTF8, "application/json");

            //HTTP POST
            var postTask = await client.PostAsync("https://localhost:44385/" + "Jogos/CreateJogo", stringContent);

            //postTask.Wait();

            Assert.True(postTask.IsSuccessStatusCode);
        }
    }
}
