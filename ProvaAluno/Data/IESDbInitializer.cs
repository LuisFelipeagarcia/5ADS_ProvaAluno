using Microsoft.EntityFrameworkCore;
using ProvaAluno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAluno.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();

            if (context.Alunos.Any())
            {
                return;
            }

            var alunos = new Aluno[]
            {
                new Aluno{Nome = "Christina", Curso="ADS",     Endereco="R. Celeste Volpini 400",  Idade=19, RA=123456},
                new Aluno{Nome = "Eduardo",   Curso="ADM",     Endereco="AV. Rodolfo 132",         Idade=20, RA=256985},
                new Aluno{Nome = "Maryana",   Curso="ADM",     Endereco="R. Geraldo ackerman 40",  Idade=27, RA=147836},
                new Aluno{Nome = "Ellen",     Curso="Direito", Endereco="R. Pará 132",             Idade=25, RA=349875},
                new Aluno{Nome = "André",     Curso="ADS",     Endereco="R. gustavo de Conde 852", Idade=30, RA=159484},
                new Aluno{Nome = "Danilo",    Curso="Direito", Endereco="R. Parana 146",           Idade=32, RA=197852},
                new Aluno{Nome = "Estevão",   Curso="Direito", Endereco="AV. Santos 187",          Idade=27, RA=321456},
                new Aluno{Nome = "Gabriel",   Curso="Redes",   Endereco="R. Bruno Correa 560",     Idade=30, RA=987654},
                new Aluno{Nome = "Patricia",  Curso="Redes",   Endereco="R. Celeste Volpini 405",  Idade=35, RA=369852},
                new Aluno{Nome = "Raul",      Curso="ADS",     Endereco="R. Celeste Volpini 410",  Idade=32, RA=147852},

            };

            
            foreach (Aluno a in alunos)
            {
                context.Alunos.Add(a);
            }
            
            context.SaveChanges();
            
        }
    }
}
