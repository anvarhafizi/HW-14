using System;

namespace HW_14
{
    class Program
    {
        delegate cases infomation<cases>(cases x, cases y);
      static void Main(string[] args)
      {
         
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
