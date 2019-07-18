using System;

namespace Command.Business.Util
{
    public static class StringExtension
    {
        public static bool CompareIgnoreCase(this string value, string input)
        {
            return String.Compare(value, input, true) == 0;
        }
    }
}
