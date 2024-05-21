using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sapiens.Shared.Entities
{
    public class Aluno
    {
        [StringLength(100)]
    public string Nome { get; set; }

    public string Matricula { get; set; }

    public string Curso { get; set; }

    public string DataNascimento { get; set; }

    public Curso(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return Nome;
    }
    }
}