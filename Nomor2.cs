using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Logic_NawaData_2
{
    public class Nomor2
    {
		public static void Main()
		{
			string s = Console.ReadLine();
			char[] charArray = s.ToCharArray();
			Array.Sort(charArray);

			string vocal = "";
			string konsonant = "";

			for (int i = 0; i < charArray.Length; i++)
			{
				if (Convert.ToString(charArray[i]) == "a" || Convert.ToString(charArray[i]) == "i" || Convert.ToString(charArray[i]) == "u"
					|| Convert.ToString(charArray[i]) == "e" || Convert.ToString(charArray[i]) == "o")
				{
					vocal += Convert.ToString(charArray[i] + ",");
				}
				else
				{
					konsonant += Convert.ToString(charArray[i] + ",");
				}
			}

			Console.Write(vocal);
			Console.WriteLine();
			Console.WriteLine();
			Console.Write(konsonant);
		}
    }
}
