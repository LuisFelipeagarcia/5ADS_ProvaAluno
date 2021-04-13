using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAluno.Models
{
    public class Aluno
    {
        [Key]
        public long? AlunoID { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]

        public int Idade { get; set; }
        [Required]
        public int RA { get; set; }
        [Display(Name = "Endereço")]
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Curso { get; set; }
    }
}
