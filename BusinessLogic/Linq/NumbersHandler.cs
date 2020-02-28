using System;
using System.Linq;
using System.Collections.Generic;


namespace BusinessLogic.Linq
{
     class NumbersHandler
     {
          private List<int> numbers = new List<int> { 20, 35, 17, 105, 90 };

          /*
          ==> 20
          ==> 35
          ==> 105
          ==> 90
          */
          public void DivisibleBy(int number)
          {
               IEnumerable<int> divisableNumbers = numbers.Where(s => s % number == 0);

               foreach(int num in divisableNumbers)
                    Console.WriteLine(num);

          }
          /*
          ==> 20
          ==> 35
          ==> 90
          ==> 105
          */
          public void DivisibleByAndOrderedAsc(int number)
          {
               IEnumerable<int> divisableNumbers = numbers.Where(i => i % number == 0).OrderBy(i => i);

               foreach(int num in divisableNumbers)
                    Console.WriteLine(num);
     
          }
          /*
          ==> 105
          */
          public void BiggestNumber()
          {
               Console.WriteLine(numbers.Max(i => i));
          }

          /*
          ==> 105
          */
          public void SecondLastNumber()
          {
               Console.WriteLine(numbers.AsEnumerable().Reverse().Skip(1).First());
          }

          /*
          ==> 90
          */
          public void SecondLargest()
          {
               Console.WriteLine(numbers.OrderBy(i => i).Reverse().Skip(1).First());   
          }
     }
}