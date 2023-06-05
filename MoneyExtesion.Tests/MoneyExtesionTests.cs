namespace MoneyExtesion.Tests;

[TestClass]
public class MoneyExtesionTests
{
    [TestMethod]
    public void ShouldConvertDecimaToInt()
    {


        decimal valor = 297.98M;
        var cents = valor.ToCents();


        Assert.AreEqual(29798,cents);
    }



}