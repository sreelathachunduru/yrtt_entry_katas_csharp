using System;
using System.Collections.Generic;
using System.Linq;

// In this Kata, you will be given an array of numbers in which two numbers occur once and the rest occur only twice. 
// Your task will be to return the sum of the numbers that occur only once.
// For example, repeats([4,5,7,5,4,8]) = 15 because only the numbers 7 and 8 occur once, and their sum is 15.
// More examples in the test cases below.

// Good luck!

namespace TechReturners.Tasks
{
    public class Exercise001
    {
        public static int Singles(List<int> source)
        {
			int sumnumbers=0;
					    IEnumerable<int> duplicates = source.GroupBy(x => x)
                                        .Where(g => g.Count() > 1)
                                        .Select(x => x.Key);
		    foreach (int ele in source){
			 if(!(duplicates.Contains(ele)))
			 {
				 sumnumbers=sumnumbers+ele;
			 }	
        }
						 return sumnumbers;
            throw new NotImplementedException();
		}
		
		public static void Main() {
		   int output=0;
		    var source = new List<int>()
			{
 				4,5,7,5,4,8
			};	
			output=Exercise001.Singles(source);
		  Console.WriteLine(output);
      }
    }
}
