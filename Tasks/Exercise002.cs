


using System;

// The clock shows 'h' hours, 'm' minutes and 's' seconds after midnight.
// Your task is to make the 'past' function return the time converted to milliseconds.
// More examples in the test cases below..

namespace TechReturners.Tasks
{
    public class Exercise002
    {
        public static int Past(int h, int m, int s)
        {
			return ((((h*60)+m)*60+s)*1000);
            throw new NotImplementedException();
        }
		public static void Main()
		{
			var milliSeconds=Exercise002.Past(1,0,0);
			Console.WriteLine(milliSeconds);
		}
    }
}
