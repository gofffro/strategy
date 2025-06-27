using System;

namespace strategy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Context context = new Context();

      context.SetStrategy(new AddStrategy());
      Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

      context.SetStrategy(new SubtractStrategy());
      Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

      context.SetStrategy(new MultiplyStrategy());
      Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));
    }
  }

  public interface IStrategy
  {
    int DoOperation(int a, int b);
  }

  public class AddStrategy : IStrategy
  {
    public int DoOperation(int a, int b)
    {
      return a + b;
    }
  }

  public class SubtractStrategy : IStrategy
  {
    public int DoOperation(int a, int b)
    {
      return a - b;
    }
  }

  public class MultiplyStrategy : IStrategy
  {
    public int DoOperation(int a, int b)
    {
      return a * b;
    }
  }

  public class Context
  {
    private IStrategy strategy;

    public void SetStrategy(IStrategy strategy)
    {
      this.strategy = strategy;
    }

    public int ExecuteStrategy(int a, int b)
    {
      return strategy.DoOperation(a, b);
    }
  }
}
