using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulersOrbit
{
    public class Program
    {
        //There's probably a lot more comments here than I might otherwise put, but I wanted to make sure I understood the logic behind the math I was doing and to keep it all straight in my head.
        public static void Main(string[] args)
        {

        }

        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.
        //brute force... I can do better
        public static int ProjectEulerQuestion1(int number)
        {
            //something to put our current total in
            int result = 0;

            //loop through all numbers below 1000
            for (int i = 1; i <= number; i++)
            {
                //check to see if current number is evenly divisble my 3 or 5
                if(((i % 3) == 0) || ((i % 5) == 0))
                {
                    //if divisible, add current number to current total
                    result += i;
                }
            }

            //return current total
            return result;
        }

        //Gray was looking over my shoulder being nosey and suggested I google arithmetic progression
        public static int ProjectEulerQuestion1a(int number)
        {
            //add all the numbers below 'number' divisble by 3 and all numbers below 100 divisble by 5
            //this didn't return correct answer because numbers divisible by three and five are added twice, so minus out divisible by 15 (three and five) once to remove duplicates
            //this seems like fizz buzz on steriods

            int three = 3 * SumOfNumsDivisibleBy(number, 3);
            int five = 5 * SumOfNumsDivisibleBy(number, 5);
            int fifteen = 15 * SumOfNumsDivisibleBy(number, 15);

            return three + five - fifteen;
        }

        public static int SumOfNumsDivisibleBy(int divideThisNumber, int byThisNumber)
        {
            //apparently there is a formula for getting the sum of a sequence of numbers, math is awesome
            //arthimetic progression formula for sum of divisible by is sum = n * (a1 + a2) / 2
            //we need a list of all numbers below 'divideThisNumber' that are multiples of 'byThisNumber', let's name this list 'a'

            //a1 equals lowest number in 'a' or in this case 1
            var a1 = 1;

            //a2 equals last number in 'a' or in this case ('divideThisNumber' / 'byThisNumber') || highest multiple of byThisNumber in divideThisNumber
            var a2 = divideThisNumber / byThisNumber;

            //n equals a.Count() which is also equal to a2
            var n = divideThisNumber / byThisNumber;

            //I found this website very helpful https://www.ck12.org/book/CK-12-Algebra-II-with-Trigonometry-Concepts/section/11.7/
            return n * (a1 + a2) / 2;
        }

        //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.
        //This seems pretty straightforward, is there another way to solve this
        public static int ProjectEulerQuestion4()
        {
            int result = 0;

            for (var i = 100; i < 1000; i++)
            {
                for (var j = 100; j < 1000; j++)
                {
                    int product = i * j;

                    if (product.ToString() == new String(product.ToString().Reverse().ToArray()))
                    {
                        if (product > result) result = product;
                    }
                }
            }

            return result;
        }

    }
}
