using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();
            
            //-----START HERE------------------------------------------
            //DONE -- Create a variable of type int and name it num  -- DONE
            //initialize the variable with a value of 0 -- DONE
            // Create a do-while loop and use the template below: -- DONE
            // Then add num to the collection - numbers-- DONE
            // Hint: reference num inside of the Add method's parentheses-- DONE
            // Create a while loop-- DONE
            // Then add num to the collection numbers-- DONE
            // HINT: copy how this was done in the do while loop-- DONE
            // Create a foreach loop using the collection - numbers-- DONE
            //In the scope of the foreach loop, print each number in numbers-- DONE
            // Create a for loop - this will print the numbers in reverse order - from 200 to 1-- DONE
            // in your initializer set the value of i to 199-- DONE
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)-- DONE
            // AND as long as i is greater than or equal to 0-- DONE
            // Decrement i by 1-- DONE
            // place numbers[i] inside of the Console.WriteLine() method-- DONE

            var num = 0;

            do
            {
                num++;
                
                numbers.Add(num);

            } while(num < 100);


            while (num < 200) //num is less than 200
            {
                num++;
                numbers.Add(num);
       

            } 
            Console.WriteLine("Increase:");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");
            
            for (int i = 199; i >= 0; i--)//start for loop here
            {
                    Console.WriteLine(numbers[i]);
            }
                //------------End of exercise
        }
    }
}
