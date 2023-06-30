using System;
using System.Text.RegularExpressions;

namespace T9
{
	public static class StringExtension
	{
		public static string ChuanHoa(this string obj)
		{
            return Regex.Replace(obj.Trim(), @"\s+", " ");
		}
	}
}

