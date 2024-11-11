using System.Reflection;
using checktheexam;
namespace Test;

public class UnitTest1
{
    [Fact (DisplayName = "Elev skickar in endast ett svar som är felaktigt. Returnerar 0.")]
    public void OneWrongAnswer_ShouldReturnZero()
    {
        var result = Kata.CheckExam(["a"], ["b"]);
        Assert.Equal(0, result);
    }

    [Fact (DisplayName = "Elev skickar in endast ett svar som är korrekt. Returnerar 4.")]
    public void OneRightAnswer_ShouldReturnFour()
    {
        var result = Kata.CheckExam(["a"], ["a"]);
        Assert.Equal(4, result);
    }
}