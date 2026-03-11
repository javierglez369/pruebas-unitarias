using Calculadora;

namespace Calculadora.Tests;

public class OperacionesMatematicasTests
{

    //Arrange compartido
    private readonly OperacionesMatematicas _operacionesMatematicas = new();

    [Fact]
    public void Sumar_DosPositivos_RetornaLaSuma()
    {
        //Arrange    
        int a = 3, b = 6;

        // Act
        int resultado = _operacionesMatematicas.Sumar(a, b);

        // Assert
        Assert.Equal(9, resultado);

    }

    [Fact]
    public void Sumar_NegativoMasPositivo_RetornaValorCorrecto()
    {
        //Arrange
        int a = -2, b = 6;

        // Act
        int resultado = _operacionesMatematicas.Sumar(a, b);

        // Assert
        Assert.Equal(4, resultado);

    }

    [Fact]
    public void Sumar_CeroMasCero_RetornaCero()
    {
        //Arrange
        int a = 0, b = 0;

        //Act
        int resultado = _operacionesMatematicas.Sumar(a, b);

        //Assert
        Assert.Equal(0, resultado);

    }




}
