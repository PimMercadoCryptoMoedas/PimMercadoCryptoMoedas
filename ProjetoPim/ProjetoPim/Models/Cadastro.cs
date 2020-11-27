using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPim.Models
{
    public class Cadastro
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
    }
}