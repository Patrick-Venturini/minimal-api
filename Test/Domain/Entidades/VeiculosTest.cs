using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Dominio.Entidades;

namespace Test.Domain.Entidades
{
    public class VeiculosTest
    {
        [TestMethod]
        public void TestarGetSetPropriedades()
        {
            // Arrange
            var veiculo = new Veiculo();

            // Act
            veiculo.Id = 1;
            veiculo.Nome = "teste";
            veiculo.Marca = "teste";
            veiculo.Ano = 1998;

            //Assert
            Assert.AreEqual(1, veiculo.Id);
            Assert.AreEqual("teste", veiculo.Nome);
            Assert.AreEqual("teste", veiculo.Marca);
            Assert.AreEqual(1998, veiculo.Ano);
        }
    }
}