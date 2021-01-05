using System.ComponentModel.DataAnnotations;


namespace MyApi.API.Entities
{
    public class Carro
    {
        [Key]
        public int Id { get;  set; }
        public int ano { get;  set; }

        public string modelo { get;  set; }

        public int PessoaId { get; set; }
        public Pessoa pessoa { get; set; }
    }
}