using Microsoft.AspNetCore.Mvc;
using SenaiApi.Domain.DTos;
using SenaiApi.Service.Interface;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService) 
        {
            _pessoaService = pessoaService;
        }

        [HttpPost]
        public IActionResult Salvar([FromBody]PessoaDTo pessoa) 
        {
            try
            {

                return Ok();
            } catch (Exception ex)
            {
                return BadRequest();
            }
        }


    }
}
