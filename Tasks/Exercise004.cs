using System;
using System.Text;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word..
// Leave punctuation marks untouched.

//Not Clear about Punctuation Marks.
namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string str)
        {
			string[] str_array = str.Split(' ');
 StringBuilder builder = new StringBuilder();
for (int i = 0; i < str_array.Length; i++) {
    str_array[i] = str_array[i].Substring(1) +str_array[i].Substring(0,1)+"ay";
	builder.Append(str_array[i]);
	builder.Append(" ");
}
			return builder.ToString();
            throw new NotImplementedException();
        }
		public static void Main()
		{
			var Final=Exercise004.PigIt("test find word");
			Console.WriteLine(Final);
		}
    }
}