using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using Dados;

namespace Repositorio
{
    public class PacienteRepositorio: RepositorioBase
    {
        public PacienteTO GetPacientePorId(int id)
        {
            Paciente paciente = this.Contexto.Pacientes.Where(p => p.Id == id).FirstOrDefault();

            return paciente.ToPacienteTO();
        }
    }
}
