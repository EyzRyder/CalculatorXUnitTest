using NewTalents.Models;

namespace TestNewTalents;

public class UnitTest1
{

	public Calculadora construirClasse()
	{
		string data = "20/04/2024"
	        Calculadora calc = new Calculadora(data);
		
	}
    [Fact]
    public void TesteSomar1()
    {
	    Calculadora calc = construirClasse();

	    int res = calc.somar(1,2);

	    Assert.Equal(3, res);

    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TestSomarLista(int val1, int val2, int res)
    {
	    Calculadora calc = construirClasse();

	    int resCalc = calc.somar(val1, val2);

	    Assert.Equal(res, resCalc );
    }

    [Theory]
    [InlineData(2,1,1)]
    [InlineData(4,5,-1)]
    public void TestSubtrairLista(int val1, int val2, int res)
    {
	    Calculadora calc = construirClasse();

	    int resCalc = calc.subtrair(val1, val2);

	    Assert.Equal(res, resCalc );
    }

    [Theory]
    [InlineData(1,2,2)]
    [InlineData(4,5,20)]
    public void TestMultiplicarLista(int val1, int val2, int res)
    {
	    Calculadora calc = construirClasse();

	    int resCalc = calc.mutiplicar(val1, val2);

	    Assert.Equal(res, resCalc );
    }

    [Theory]
    [InlineData(2,1,2)]
    [InlineData(20,5,4)]
    public void TestDividirLista(int val1, int val2, int res)
    {
	    Calculadora calc = construirClasse();

	    float resCalc = calc.dividir(val1, val2);

	    Assert.Equal(res, resCalc );
    }
    
    [Fact]
    public void TestarDivisaoPorZero()
    {
	    Calculadora calc = construirClasse();

	    Assert.Throws<DivideByZeroException>(
			    () => calc.dividir(3,0)
	    );    
    }

    [Fact]
    public void TestarHistorico()
    {
	    Calculadora calc = construirClasse();

	    calc.somar(1,2);
	    calc.somar(5,2);
	    calc.somar(7,3);
	    calc.somar(8,4);
	    calc.somar(8,4);
	    
	    var list = calc.historico();

	    Assert.NotEmpty(list);
	    Assert.Equal(3,list.Count);
    }
}
