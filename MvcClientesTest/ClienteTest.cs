using MvcClientes.Services;

namespace MvcClientesTest;

public class ClienteTest
{
    [Fact]
    public void ValidarSeNomeEstaVazio()
    {
        //arrange
        var nome = "";
        //act
        var resultado = ValidacoesCLiente.ValidarNomeVazio(nome);
        //assert
        Assert.True(resultado);
    }

    [Fact]
    public void ValidarSeDocumentoEstaVazio()
    {
        //arrange
        var documento = "";
        // act
        var resultado = ValidacoesCLiente.ValidarDocumentoVazio(documento);
        // assert
        Assert.True(resultado);
    }
}