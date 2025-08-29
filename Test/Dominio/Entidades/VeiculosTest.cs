using MinimalApi.Dominio.Entidades;

namespace Test.Dominio.Entidades;

[TestClass]
public sealed class VeiculosTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var veiculo = new Veiculo();

        // Act
        veiculo.Id = 1;
        veiculo.Nome = "Teste";
        veiculo.Marca = "Teste";
        veiculo.Ano = 0;


        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Teste", veiculo.Nome);
        Assert.AreEqual("Teste", veiculo.Marca);
        Assert.AreEqual(0, veiculo.Ano);
    }
}
