using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyApi.API.Entities
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Carro> carros { get; set; }
        
    }
}