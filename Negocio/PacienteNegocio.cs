using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace Negocio
{
    public class PacienteNegocio
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;
        public PacienteNegocio(IPacienteRepositorio pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public PacienteTO GetPacientePorId(int id)
        {
            return _pacienteRepositorio.GetPacientePorId(id);
        }

        public List<PacienteTO> GetTodos()
        {
            return _pacienteRepositorio.GetTodos();
        }

        public void Novo(PacienteTO paciente)
        {
            _pacienteRepositorio.Novo(paciente);
        }

        public void Atualizar(PacienteTO paciente)
        {
            _pacienteRepositorio.Atualizar(paciente);
        }
    }
}
