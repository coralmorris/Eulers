using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulersOrbit
{
    class Trash
    {

        //can I solve it backwards
        //start by passing in largest number in range, i.e. largest three digit number
        public static int ProjectEulerQuestion4a(int largestNumber)
        {
            int result = 0;

            //what is the square of largest three digit number
            int squareOfLargestNumber = largestNumber * largestNumber;

            //let's get first half of that number and turn it into a palindrome 
            int firstHalf = Convert.ToInt32(squareOfLargestNumber.ToString()
                .Substring(0, (squareOfLargestNumber.ToString().Length / 2)));

            //at this point in time I have already decdied I am over complicating this in order to make it generic, but I'm going to keep coding anyway... because it's my code so why not
            int lengthOfLargerestNumber = largestNumber.ToString().Length;

            //now what... loop through to see if palindrome is product of two 3-digit numbers 
            //nope that won't work... repeative nested for loops are ugly, trying a while loop
            bool success = false;
            while (!success)
            {
                //moved part of my palindrome code into separate function and will pass increasingly smaller numbers to it
                firstHalf = firstHalf--;
                var palindrom = GetPalindrom(firstHalf);
                //this is questionable
                for (var i = largestNumber; i > 0; i--)
                {
                    //if palidrome modulus i equals zero then palindrome is a product of i and some other number
                    if (palindrom % i == 0)
                    {
                        success = true;
                        //is palindrom product of two three-digit numbers, do I need to check for this
                        var product1 = palindrom / i;
                        var product2 = i;
                        if (product1.ToString().Length == lengthOfLargerestNumber &&
                            product2.ToString().Length == lengthOfLargerestNumber)
                        {
                            result = palindrom;
                            success = true;
                            break;
                        }
                    }

                }
            }

            //this doesn't test for the possiblity of odd digit palindromes, how can I remedy that...
            return result;
        }

        public static int GetPalindrom(int firstHalf)
        {
            string secondHalf = new String(firstHalf.ToString().Reverse().ToArray());

            int palindrome = Convert.ToInt32(firstHalf.ToString() + secondHalf);

            return palindrome;
        }

        //'number' should be largest possible number that can be used to get palindrome
        //e.g. if using only 3 digit numbers 'number' equals largest three digit number
        public static int BadAttempt(int number)
        {
            int result = 0;

            //square 'number' and get the largest possible product that could be a palindrom
            int squareOfNumber = number * number;

            //lets loop through all the numbers =< 'squareOfNumber' the first one we find should be the highest palindrome because we started at the highest product... I hope
            for (var i = squareOfNumber; i > 0; i--)
            {
                //now check if its a palindrome
                if (i.ToString() == new String(i.ToString().Reverse().ToArray()))
                {
                    result = i;
                    break;
                }
            }
            //ummm... this won't work at all. I have no way of confirming this is a product of two three-digit numbers or starting over if it's not... sheesh
            return result;
        }
    }
}
