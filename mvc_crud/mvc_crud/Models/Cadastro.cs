using System;
using System.ComponentModel.DataAnnotations;

namespace mvc_crud.Models
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        public string RG { get; set; }
        
        public int Celular { get; set; }
        public string Email { get; set; }
    }
}
