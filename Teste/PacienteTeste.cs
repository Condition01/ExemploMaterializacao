using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;
using System;
using TO;
using Moq;
using Repositorio;

namespace Teste
{
    [TestClass]
    public class PacienteTeste
    {
        private Mock<IPacienteRepositorio> _pacienteRepositorio;
        public PacienteTeste()
        {
            _pacienteRepositorio = new Mock<IPacienteRepositorio>();
        }

        [TestMethod]
        public void Novo_Paciente_ComSucesso()
        {
            try
            {
                //Arrange (Preparação dos objetos usados no teste, inclusive Mocks)
                PacienteTO paciente = new PacienteTO()
                {
                    Nome = "Jõao da Silva",
                    NomeMae = "Maria Silva",
                    Nascimento = DateTime.Today.AddYears(-10),
                    Sexo = SexoEnum.Masculino
                };
                _pacienteRepositorio.Setup(r => r.GetPacientePorId(123)).Returns(new PacienteTO());
                PacienteNegocio pacienteNegocio = new PacienteNegocio(_pacienteRepositorio.Object);
             
                //Act (Chamada das funções)
                pacienteNegocio.Novo(paciente);

                //Assert (Ver resultado)
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
