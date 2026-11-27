namespace citester;
using citester.calc;
public class calcTestConsole{
    [Fact]
    public void deve_somar_essa_bomba(){
        var result = SimpleAdd.sumValues(0,0);
        Assert.True(result == 0);
    }
}