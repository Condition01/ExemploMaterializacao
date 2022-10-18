using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioBase
    {
        public ExemploMaterializacaoModel Contexto { get; set; }

        public RepositorioBase()
        {
        }
    }
}