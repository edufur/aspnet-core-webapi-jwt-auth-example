using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiJwtAuthDemo.Util
{
    public static class MiscUtilities
    {
        public static string GetRandomString(int Size)
        {
            Random random = new Random();
            string input = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMONPQRSTUVWXYZ0123456789!@#$%^&*()-=_+;:'";
            var chars = Enumerable.Range(0, Size)
                                   .Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }
        public static string GetKeyValue(string keyName)
        {
            return "";
        }
    }
}
