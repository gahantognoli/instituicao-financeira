using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoSys.InstituicaoFinanceira.Aplicacao.Interfaces.Servicos;
using PontoSys.InstituicaoFinanceira.Aplicacao.Modelos;

namespace PontoSys.InstituicaoFinanceira.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaFisicaController : ControllerBase
    {
        private readonly IPessoaFisicaAppService _pessoaFisicaAppService;

        public PessoaFisicaController(IPessoaFisicaAppService pessoaFisicaAppService)
        {
            _pessoaFisicaAppService = pessoaFisicaAppService;
        }

        // GET: api/PessoaFisica
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PessoaFisica/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PessoaFisica
        [HttpPost]
        public IActionResult Post([FromBody] PessoaFisicaModelo pessoaFisicaModelo)
        {
            var id = _pessoaFisicaAppService.Adicionar(pessoaFisicaModelo).ClienteId;
            return Created($"api/pessoaFisica/{id}", id);
        }

        // PUT: api/PessoaFisica/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
