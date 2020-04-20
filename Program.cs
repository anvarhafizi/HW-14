using System;

namespace HW_14
{
    class Program
    {
        delegate cases infomation<cases>(cases x, cases y);
      static void Main(string[] args)
      {
          System.Console.Write("Enter the first number=");
          double a=Convert.ToDouble(Console.ReadLine());
          System.Console.Write("Enter the second number=");
          double b=Convert.ToDouble(Console.ReadLine());

          System.Console.WriteLine(@"What do you want to do? If you want 
          +;
          -;
          *;
          /;
          ");
      
        infomation<double>info;
        string operations=Console.ReadLine();
        switch(operations)
        {
            case "+": info=sum;
            System.Console.Write($"Answer {a}+{b}={info.Invoke(a,b)}"); break;
            case "-": info=minus;
            System.Console.Write($"Answer {a}-{b}={info.Invoke(a,b)}"); break;
            case "*": info=multplay;
            System.Console.Write($"Answer {a}*{b}={info.Invoke(a,b)}"); break;
            case "/": info=distribution;
            System.Console.WriteLine($"Answer {a}/{b}={info.Invoke(a,b)}"); break;
        }
      }
        
      public static expencive sum<expencive>(expencive x, expencive y)
      {
          return (dynamic)x + (dynamic)y;
      }
      
      public static expencive minus<expencive>(expencive x, expencive y)
      {
          return (dynamic)x-(dynamic)y;
      }
      
      public static expencive multplay<expencive>(expencive x, expencive y)
      {
          return (dynamic)x*(dynamic)y;
      }

    public static expencive distribution<expencive>(expencive x, expencive y)
    {
        return (dynamic)x/(dynamic)y;
    }
    }

}
