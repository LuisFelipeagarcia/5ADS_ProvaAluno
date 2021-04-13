using Microsoft.EntityFrameworkCore;
using ProvaAluno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAluno.Data
{
    public class IESContext : DbContext
    {

        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }

}
