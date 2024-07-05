using APICRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICRUD.Controllers{
    [Route("api/[controller]")] // comando para geração da rota que vai ser acessada
    [ApiController] // inicializa o controler
    public class UsuarioController : ControllerBase{
        [HttpGet]//gera a inicialização para o swagger
        public ActionResult<List<UsuarioModel>> BuscarTodosUsuarios(){ // Criação do nosso primeiro EndPoint que cria uma ação que resulta na geração de uma lista acessando o UsuarioModel
            return Ok(); // retorna sempre 200
        }
    }
}
