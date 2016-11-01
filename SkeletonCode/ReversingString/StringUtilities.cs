using System.Linq;

namespace SkeletonCode.ReversingString
{
	public class StringUtilities
	{
		public string Reverse(string input)
		{
			string output = string.Empty;

            // If string is NOT null or NOT empty, then only reverse the string
            if (!string.IsNullOrEmpty(input))
            {
                output =  new string(input.ToCharArray().Reverse().ToArray());

                // --------------Alternative using StringBuilder-----
                //var builder = new StringBuilder(input.Length);
                //for (int i = input.Length - 1; i >= 0; i--)
                //{
                //    builder.Append(input[i]);
                //}

                //output = builder.ToString();
            }

			return output;
		}
	}
}
