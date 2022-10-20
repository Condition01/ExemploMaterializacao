using Dados;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace Repositorio
{
    public interface IPacienteRepositorio
    {
        PacienteTO GetPacientePorId(int id);
        List<PacienteTO> GetTodos();
        void Novo(PacienteTO paciente);
        void Atualizar(PacienteTO paciente);
    }
}
