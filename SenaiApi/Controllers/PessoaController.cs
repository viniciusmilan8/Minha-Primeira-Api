using Microsoft.AspNetCore.Mvc;
using SenaiApi.Domain.DTos;
using SenaiApi.Domain.Entidades;
using SenaiApi.Repository.Interfaces;
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

        [HttpGet]
        public IActionResult Get() 
        {
            var pessoas = _pessoaService.BuscarTodos();
            return new JsonResult(pessoas);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _pessoaService.Delet(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Salvar([FromBody]PessoaDTo pessoa) 
        {
            try
            {
                _pessoaService.Salvar(pessoa);
                return Ok();
            } catch (Exception ex)
            {
                return BadRequest();
            }
        }


    }
}
