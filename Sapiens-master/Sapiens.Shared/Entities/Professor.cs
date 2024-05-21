using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sapiens.Shared.Entities
{
    public class Professor
    {
          [StringLength(100)]
    public string Nome { get; set; }

    public string Cpf { get; set; }

    public string Titulacao { get; set; }


    }
}