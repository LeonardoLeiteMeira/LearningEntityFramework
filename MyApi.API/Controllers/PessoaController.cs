using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyApi.API.Entities;

namespace MyApi.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Pessoa> GetPessoas(){
            return new List<Pessoa>();
        }
    }
}