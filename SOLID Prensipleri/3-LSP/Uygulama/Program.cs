
Calculator positiveCalculator = new PositiveCalculator();
var positiveSum = positiveCalculator.Sum(10, 20);
System.Console.WriteLine(positiveSum);

var calculator = new Calculator();
var sum = calculator.Sum(10, -30);
System.Console.WriteLine(sum);





public class Calculator
{
    public virtual int Sum(int x, int y)
    {
        return x + y;
    }

}

public class PositiveCalculator : Calculator
{
    public override int Sum(int x, int y)
    {
        if ((x + y) <= 0)
            throw new Exception("Result is not positive");

        return x + y;
    }
}
