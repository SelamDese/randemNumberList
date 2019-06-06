using System;
using System.Collections.Generic;

namespace randomnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
// Use the following code to create a list of random numbers. 
// Each number will be between 0 and 9.
Random random = new Random();
  List<int> numbers = new List<int> {
    random.Next(10),
    random.Next(10),
    random.Next(10),
    random.Next(10),
    random.Next(10),
};
// Use a for loop to iterate over all numbers between 0 and numbers.Count - 1.
            for (int i=0; i<numbers.Count-1; i++) {
             Console.WriteLine(numbers[i]);
}
// Inside the body of the for loop determine if the current loop index is contained inside of the numbers list. 
// Print a message to the console indicating whether the index is in the list.
             for (int i=0; i<numbers.Count-1; i++) {
                 if (numbers.Contains(i)) {
                    Console.WriteLine(" index is inside the numbers list.");
                  }else{
                     Console.WriteLine(" index is not inside the numbers list."); 
                  }
            }
        }
    }
}

