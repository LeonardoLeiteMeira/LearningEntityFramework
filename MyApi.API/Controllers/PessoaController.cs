using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MyApi.API.Entities;
using System.Linq;

namespace MyApi.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PessoaController(AppDbContext context){
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPessoas(){

            try{

                List<Pessoa> pessoas = _context.Pessoas
                    .AsNoTracking()
                    .Include(p => p.carros)
                    .ToList();

                return Ok(pessoas);
            }catch(Exception er){
                Console.WriteLine(er);
                return BadRequest(new List<Pessoa>());
            }

        }

        [HttpGet("{id}")]
        public IActionResult GetPessoaById(int id){
            var pessoa = _context.Pessoas.AsNoTracking().Include(p=>p.carros).FirstOrDefault(p=> p.Id==id );

            return Ok(pessoa);
        }


        [HttpPost]
        public IActionResult CreatePeople(Pessoa pessoa){
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
            
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePeople(int id, Pessoa pessoa){

            var currentPessoa = _context.Pessoas
                .AsQueryable()
                .Include(pessoa=>pessoa.carros)
                .FirstOrDefault(pessoa=>pessoa.Id==id);
            
            if(currentPessoa == null) return BadRequest();

            /*
                UPDATE
            */
            
            return Ok();
        }
    } 
}